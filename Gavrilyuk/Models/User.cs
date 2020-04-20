using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Gavrilyuk.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string AssuranceType { get; set; }
        public DateTime DateOfAssurance { get; set; }
        public bool AssuranceCases { get; set; } 
    }

    public class UserDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}