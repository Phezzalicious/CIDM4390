using System;
using System.Collections.Generic;
using MyData.Models.Knowledge;
using MyData.Models.Disposition;

namespace MyData.Data.Models.Competency
{
    public class Composite: Competency
    {
       
        public ICollection<Atomic> atomics{get;set;}


        public ICollection<Composite> composites{get;set;}
    

    }
}




