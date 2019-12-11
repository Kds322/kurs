using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kds.Models
{
    public class AppContextMy:DbContext
    {
        public AppContextMy() :base("DbConnection")
        { }
          
        public DbSet<User> Users { get; set; }
    }
}