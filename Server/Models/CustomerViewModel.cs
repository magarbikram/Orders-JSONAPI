using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    }
}