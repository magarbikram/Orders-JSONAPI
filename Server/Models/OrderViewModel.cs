using Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models
{
    public class OrderViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get;  set; }
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
        public OrderStatus Status { get; set; }
    }
}