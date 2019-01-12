using System;
using System.Data.Entity;

namespace SimpleProject.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlConnectionFactory))]
    public class MobileContext : DbContext
    {
        public MobileContext():base ("gamestore")
        {
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
