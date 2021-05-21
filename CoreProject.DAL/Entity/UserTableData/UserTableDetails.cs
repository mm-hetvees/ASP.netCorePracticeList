using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.DAL.Entity.UserTableData
{
    public class UserTableDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string UserEmail { get; set; }
    }
}
