using System;
using System.ComponentModel.DataAnnotations;

namespace CodeClub.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public DateTime DateJoined { get; set; }
        public string Major { get; set; }
        public bool BeginnersJourney {get; set;}
    }
   
}