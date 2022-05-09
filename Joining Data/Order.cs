using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_Data
{
    class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        
        

        public Order(string customerName, string item, decimal price, int quantity)
        {
            this.CustomerName = customerName;
            this.Item = item;
            this.Price = price;
            this.Quantity = quantity;
        }
        //public void PrintHead(Order currentorder, string currentCustomer)
        //{
        //    Console.WriteLine(currentCustomer);
        //    Console.WriteLine("===================");
        //    Console.WriteLine($"{currentorder.CustomerName} {currentorder.Item} {currentorder.Price} {currentorder.Quantity}");
        //}
        //public void PrintHead2(Order currentorder)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine($"{currentorder.CustomerName} {currentorder.Item} {currentorder.Price} {currentorder.Quantity}");
        //    Console.WriteLine();
        //}
      
    }
}
