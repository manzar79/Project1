using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xyz.Models
{
    public class OrderDetails
    {
        [Key]
        public int DetailsID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public double OrderPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        
    }
}