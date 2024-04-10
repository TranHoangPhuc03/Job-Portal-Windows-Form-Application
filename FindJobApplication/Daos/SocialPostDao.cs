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
            string sqlStr = @"INSERT INTO social_post (contents, post_date, account_id)
                            VALUES (@Id, @PostDate, @AccountId)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Id", socialPost.Id },
                { "@PostDate", socialPost.PostDate },
                { "@AccountId", socialPost.AccountId },
            };

            return db.Excute(sqlStr, parameters);
        }

        public List<SocialPost> FindAllSocialPost()
        {
            string sqlStr = @"SELECT * FROM social_post ORDER BY post_date DESC";

            DataTable dt = db.Read(sqlStr);
            List<SocialPost> list = new List<SocialPost>();
            foreach (DataRow dr in dt.Rows)
                list.Add(SocialPostMapper.MapToModel(dr));

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

            return db.Excute(sqlStr);
        }

        public int DeleteSocialPostById(int socialPostId)
        {
            string sqlStr = @"DELETE FROM social_post WHERE id = @SocialPostId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@SocialPostId", socialPostId },
            };

            return db.Excute(sqlStr, parameters);
        }
    }
}
