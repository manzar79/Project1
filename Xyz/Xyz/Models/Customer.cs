using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xyz.Models;

namespace Xyz.Controllers
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}