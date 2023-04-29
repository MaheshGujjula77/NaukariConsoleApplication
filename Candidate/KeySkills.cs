using System.Collections.Generic;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Skill Details
    /// </summary>
    public class KeySkills
    {
        public List<Skill> SkillList { get; set; }
    }
    public class Skill
    {
        public string SkillName { get; set; }
    }
}
