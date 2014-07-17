using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xyz.Models
{
    public class Part
    {
        public int PartID { get; set; }
        public int PartNum { get; set; }
        public double Price {get; set;}
        public string Descriotion { get; set; }

        public virtual ICollection<OrderDetails> OrderDetail { get; set; }

    }
}