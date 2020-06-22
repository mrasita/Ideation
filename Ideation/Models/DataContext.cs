using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ideation.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") //This 'DefaultConnection' should be equal to the connection string name on Web.config.
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Ideas> Ideas { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Meeting> Meetings { get; set; }


    }
}