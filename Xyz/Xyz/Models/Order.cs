using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xyz.Controllers;

namespace Xyz.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }
        public double Total { get; set; }

        
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
    }
}