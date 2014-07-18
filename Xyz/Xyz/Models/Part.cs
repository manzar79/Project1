using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xyz.Models
{
    public class Part
    {
        [Key] 
        public int PartID { get; set; }
        public int DetailsID { get; set; }
        public int PartNum { get; set; }
        public double Price {get; set;}
        public string Description { get; set; }

        public virtual ICollection<OrderDetails> OrderDetail { get; set; }

    }
}