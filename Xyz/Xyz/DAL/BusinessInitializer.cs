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
    public class BusinessInitializer : DropCreateDatabaseIfModelChanges<Business>
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
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();


            var orders = new List<Order>
            {
            new Order{CustomerId=2001, Total=2020.20},
            new Order{CustomerId=2002, Total=230020.20},
            new Order{CustomerId=2004, Total=13011.35},
            new Order{CustomerId=2010, Total=5035.85},
            };

            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

            var payments = new List<Payment>
            {
            new Payment{OrderId=2525, PaymentDate=DateTime.Parse("12-12-12"), PaymentType="Credit Card", PaymentAmount=2035},
            new Payment{OrderId=3525, PaymentDate=DateTime.Parse("11-08-12"), PaymentType="Credit Card", PaymentAmount=3000},
            new Payment{OrderId=2015, PaymentDate=DateTime.Parse("10-01-12"), PaymentType="Check", PaymentAmount=2125},
            new Payment{OrderId=0255, PaymentDate=DateTime.Parse("11-01-12"), PaymentType="Debit Card", PaymentAmount=2035},
            };
            payments.ForEach(s => context.Payments.Add(s));
            context.SaveChanges();

            var orderDetails = new List<OrderDetails>
            {
            new OrderDetails{OrderID=2525, Quantity=25, OrderPrice=2035.35},
            new OrderDetails{OrderID=3525, Quantity=15, OrderPrice=3050.35},
            new OrderDetails{OrderID=2015, Quantity=20, OrderPrice=1835.35},
            new OrderDetails{OrderID=0255, Quantity=25, OrderPrice=2035.35},
            };
            orderDetails.ForEach(s => context.OrderDetails.Add(s));
            context.SaveChanges();

            var parts = new List<Part>
            {
            new Part{DetailsID=1000, PartNum=1111, Price=250, Description="Gasket"},
            new Part{DetailsID=1001, PartNum=1122, Price=150, Description="Fan"},
            new Part{DetailsID=1002, PartNum=1144, Price=350, Description="Engine"},
            new Part{DetailsID=1003, PartNum=1551, Price=400, Description="Carborator"},
            };
            parts.ForEach(s => context.Parts.Add(s));
            context.SaveChanges();
            
        }
    }
}