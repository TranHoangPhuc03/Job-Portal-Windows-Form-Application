using FindJobApplication.DB;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Mappers;

namespace FindJobApplication.Daos
{
    public class SocialPostDao
    {
        Database db = null;
        public SocialPostDao()
        {
            db = new Database();
        }

        public int SaveNewSocialPost(SocialPost socialPost)
        {
            string sqlStr = @"
                    INSERT INTO social_post (title, contents, post_date, account_id)
                        OUTPUT INSERTED.id
                    VALUES (@Title, @Contents, @PostDate, @AccountId);
                    ";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Title", socialPost.Title },
                { "@Contents", socialPost.Contents },
                { "@PostDate", socialPost.PostDate },
                { "@AccountId", socialPost.AccountId },
            };

            int postId = Convert.ToInt32(db.ExecuteScalar(sqlStr, parameters));
            sqlStr = "";
            parameters.Clear();
            parameters.Add("@PostId", postId);
            if (socialPost.Skills.Count > 0)
            {
                string temp = @"
                    INSERT INTO social_post_skill (social_post_id, skill_id)
                    VALUES ";
                List<string> valueStrings = new List<string>();
                foreach (Skill skill in socialPost.Skills)
                {
                    valueStrings.Add($"(@PostId, @SkillId{skill.Id})");
                    parameters.Add($"@SkillId{skill.Id}", skill.Id);
                }
                temp += string.Join(", ", valueStrings);
                sqlStr += temp + ";";
            }

            return db.Execute(sqlStr, parameters);
        }

        public List<SocialPost> FindAllSocialPost()
        {
            string sqlStr = @"SELECT * FROM social_post ORDER BY post_date DESC";

            DataTable dt = db.Read(sqlStr);
            List<SocialPost> list = new List<SocialPost>();
            foreach (DataRow dr in dt.Rows)
            {
                SocialPost socialPost = SocialPostMapper.MapToModel(dr);
                socialPost.Skills.AddRange(FindSocialPostSkill(socialPost.Id));
                list.Add(socialPost);
            }

            return list;
        }

        public SocialPost FindSocialPostById(int socialPostId)
        {
            string sqlStr = @"
                            SELECT *
                            FROM social_post
                            WHERE id = @SocialPostId";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@SocialPostId", socialPostId },
            };
            DataRow dr = db.Read(sqlStr, parameters).Rows.Cast<DataRow>().FirstOrDefault();

            return SocialPostMapper.MapToModel(dr);
        }

        public int UpdateSocialPostBydId(SocialPost socialPost)
        {
            string sqlStr = @"
                            UPDATE social_post
                            SET post_date = @PostDate, contents = @Contents
                            WHERE id = @SocialPostId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@PostDate", socialPost.PostDate },
                { "@Contents", socialPost.Contents },
                { "@SocialPostId", socialPost.Id },
            };

            return db.Execute(sqlStr);
        }

        public int DeleteSocialPostById(int socialPostId)
        {
            string sqlStr = @"DELETE FROM social_post WHERE id = @SocialPostId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@SocialPostId", socialPostId },
            };

            return db.Execute(sqlStr, parameters);
        }

        public List<Skill> FindSocialPostSkill(int socialPost)
        {
            string sqlStr = @"
                            SELECT
	                            social_post_skill.social_post_id,
	                            skill.id AS id,
                                skill.name AS name
                            FROM 
	                            social_post_skill
                            INNER JOIN skill on social_post_skill.skill_id = skill.id
                            WHERE social_post_skill.social_post_id = @SocialPost";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@SocialPost", socialPost }
            };

            DataTable dt = db.Read(sqlStr, parameters);
            List<Skill> list = new List<Skill>();
            foreach (DataRow dr in dt.Rows)
                 list.Add(SkillMapper.MapToModel(dr));

            return list;
        }
    }
}
