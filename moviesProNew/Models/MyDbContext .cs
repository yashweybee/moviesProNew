using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace moviesProNew.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> cs { get; set; }


    }
}