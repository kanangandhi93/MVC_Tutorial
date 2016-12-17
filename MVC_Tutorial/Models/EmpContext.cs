using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class EmpContext : DbContext
    {
        public DbSet<Employee> emp { get; set; }
    }
}