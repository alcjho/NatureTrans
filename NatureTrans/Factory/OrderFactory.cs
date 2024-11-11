using Accessibility;
using NatureTrans.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Factory
{
    internal class OrderFactory: IFormFactory
    {
        private readonly OrderService _orderService;
        private readonly InventoryService _inventoryService;
        private readonly InventoryForm _inventoryForm;

        public OrderFactory(OrderService orderService, InventoryService inventoryService, InventoryForm inventoryForm)
        {
            _orderService = orderService;
            _inventoryService = inventoryService;
            _inventoryForm = inventoryForm;
        }

        public NewCommand CreateNewCommand()
        {
            return new NewCommand(_orderService, _inventoryService, _inventoryForm);
        }

    }
}
