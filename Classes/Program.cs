using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Eskişehir";
            customer.Id = 1;
            customer.FirstName = "Murat";
            customer.LastName = "İpek";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Afyon",
                FirstName = "Melih",
                LastName = "İpek"
            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
