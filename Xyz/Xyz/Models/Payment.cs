using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xyz.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int OrderId {get; set;}
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string PaymentAmount { get; set; }

        public virtual Order Orders { get; set; }
    }
}