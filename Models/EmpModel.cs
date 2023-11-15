using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmpModel
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}