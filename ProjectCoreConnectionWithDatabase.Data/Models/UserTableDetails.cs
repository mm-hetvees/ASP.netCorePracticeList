using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCoreConnectionWithDatabase.Data.Models
{
    public class UserTableDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? Gender { get; set; }
        public string UserEmail { get; set; }
    }
}
