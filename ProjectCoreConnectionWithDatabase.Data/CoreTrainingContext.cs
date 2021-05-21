using Microsoft.EntityFrameworkCore;
using ProjectCoreConnectionWithDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCoreConnectionWithDatabase.Data
{
    public class CoreTrainingContext : DbContext
    {
        public CoreTrainingContext(DbContextOptions<CoreTrainingContext> options) :base(options) { }
        public DbSet<UserTableDetails> UserTableDetails { get; set; }

    }
}
