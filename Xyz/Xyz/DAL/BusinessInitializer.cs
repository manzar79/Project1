using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Xyz.Models;
using Xyz.Controllers;
using Xyz.DAL;

namespace Xyz.DAL
{
    public class BusinessInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Business>
    {
        protected override void Seed(Business context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstName="Carson",LastName="Alexander",PhoneNum=("2005-09-01"), Email=("abc@gmail.com")},
            new Customer{FirstName="Meredith",LastName="Alonso",PhoneNum=("2002-09-01"), Email=("abc@gmail.com")},
            new Customer{FirstName="Arturo",LastName="Anand",PhoneNum=("2003-09-01"), Email=("abc@gmail.com")},
            new Customer{FirstName="Gytis",LastName="Barzdukas",PhoneNum=("2002-09-01"), Email=("abc@gmail.com")},
           
            };

           
        }
    }
}