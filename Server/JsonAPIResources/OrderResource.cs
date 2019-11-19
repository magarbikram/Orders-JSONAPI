using Saule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.JsonAPIResources
{
    public class OrderResource : ApiResource
    {
        public OrderResource()
        {
            Attribute("Name");
            Attribute("Description");
            Attribute("Created");
            Attribute("CustomerId");
            Attribute("Status");
            BelongsTo<CustomerResource>("customer");
        }
    }
}
