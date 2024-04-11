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
        private string name;

        public UserSkill() { }
        public UserSkill(int userProfileId, int skillId, string name)
        {
            this.userProfileId = userProfileId;
            this.skillId = skillId;
            this.name = name;
        }

        public int UserProfileId { get => userProfileId; }
        public int SkillId { get => skillId; }
        public string Name { get => name; }
    }
}
