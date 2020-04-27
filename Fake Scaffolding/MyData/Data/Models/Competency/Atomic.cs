using System;
using System.Collections.Generic;
using MyData.Models.Knowledge;
using MyData.Models.Disposition;

namespace MyData.Data.Models.Competency
{
    public class Atomic:Competency
    {
    
        public ICollection<KnowledgeSkill> ksPairs{get;set;}




    }
}




