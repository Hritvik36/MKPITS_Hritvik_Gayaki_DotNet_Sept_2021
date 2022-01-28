using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC_Code_FirstExample.Models
{
    public class Students
    {
        [key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public String Lastname { get; set; }
        public int Marks { get; set; }
    }
}