using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xyz.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int OrderId {get; set;}
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public double PaymentAmount { get; set; }

        public virtual Order Orders { get; set; }
    }
}