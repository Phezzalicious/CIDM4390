using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeClub.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Member[] TeamMembers{get;set;}
        
        public string TeamLead { get; set; }
        public Project[] Projects{ get;set; }
    }
   
}