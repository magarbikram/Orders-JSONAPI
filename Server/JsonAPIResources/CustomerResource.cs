using Saule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.JsonAPIResources
{
    public class CustomerResource : ApiResource
    {
        public CustomerResource()
        {
            Attribute("Name");
        }
    }
}
