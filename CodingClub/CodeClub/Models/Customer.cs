using System;
using System.ComponentModel.DataAnnotations;

namespace CodeClub.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
   
}