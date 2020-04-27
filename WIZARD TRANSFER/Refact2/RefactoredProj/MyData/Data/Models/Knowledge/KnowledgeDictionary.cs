using System;
using System.Collections.Generic;

namespace MyData.Models.Knowledge
{
    public class KnowledgeDictionary
    {
   public int ID{get;set;}
        public string category{get;set;}
        public string discipline{get;set;}
        public string description{get;set;}
        public ICollection<KnowledgeElement> elements {get;set;}



    }
}