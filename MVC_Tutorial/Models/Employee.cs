using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    [Table("tbl_Emp")]
    public class Employee
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
    }
}