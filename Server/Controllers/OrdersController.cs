using Orders.Models;
using Orders.Services;
using Saule.Http;
using Server.JsonAPIResources;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Server.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderService orderService;
        private readonly ICustomerService customerService;

        public OrdersController()
        {
            orderService = new OrderService();
            customerService = new CustomerService();
        }

        [AllowsQuery]
        [ReturnsResource(typeof(OrderResource))]
        [DisableDefaultIncluded]
        [HttpGet]
        public async Task<IEnumerable<OrderViewModel>> Get()
        {
            IList<OrderViewModel> orderViewModels = new List<OrderViewModel>();
            IEnumerable<Order> orders = await orderService.GetOrdersAsync();
            foreach (Order order in orders)
            {
                orderViewModels.Add(await ToOrderViewModel(order));
            }
            return orderViewModels.AsEnumerable();
        }

        private async Task<OrderViewModel> ToOrderViewModel(Order order)
        {
            OrderViewModel orderViewModel = new OrderViewModel
            {
                Id = order.Id,
                Name = order.Name,
                Description = order.Description,
                Created = order.Created,
                Status = order.Status,
                CustomerId = order.CustomerId,
                Customer = await ToCustomerViewModel(order.CustomerId)
            };
            return orderViewModel;
        }

        private async Task<CustomerViewModel> ToCustomerViewModel(int customerId)
        {
            Customer customer = await customerService.GetCustomerByIdAsync(customerId);
            return new CustomerViewModel
            {
                Id = customer.Id,
                Name = customer.Name
            };
        }
    }
}
