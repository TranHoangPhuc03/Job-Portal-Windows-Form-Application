using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Models
{
    public class UserSkill
    {
        private int userProfileId;
        private int skillId;
        private string skillName;

        public UserSkill() { }
        public UserSkill(int userProfileId, int skillId, string skillName)
        {
            this.userProfileId = userProfileId;
            this.skillId = skillId;
            this.skillName = skillName;
        }

        public int UserProfileId { get => userProfileId; }
        public int SkillId { get => skillId; }
        public string SkillName { get => skillName; }
    }
}
