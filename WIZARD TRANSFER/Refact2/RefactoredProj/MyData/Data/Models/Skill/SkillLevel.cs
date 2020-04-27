using System.Collections.Generic;

namespace MyData.Models.Skill
{
    public class SkillLevel
    {
        public int ID{get;set;}
        public string term_identifier {get;set;}
        public int cartesian_index{get;set;}
        public string descriptor {get;set;}
        public ICollection<SkillVerbSynonym> synonyms{get;set;}
       
    }
}