using System;
using Microsoft.VisualBasic;

namespace zoo_management.Models.Database
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Classification { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateAcquired { get; set; }
        
        public DateTime Dob { get; set; }
        
        public int Age { get; set; }
    }
}