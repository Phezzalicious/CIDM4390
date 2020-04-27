using System;
using System.Collections.Generic;
using MyData.Models.Skill;
using MyData.Models.Knowledge;

namespace MyData.Models.Competency
{
    public class KnowledgeSkill
    {
       public int ID{get;set;}
       public KnowledgeElement knowledge;
       public SkillLevel knowledgeLevel;
    }
}