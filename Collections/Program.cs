using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();

            bool isGlassContain = dictionary.ContainsKey("glass");
            bool isTableContain = dictionary.ContainsKey("table");
            if(isTableContain)
            {
                Console.WriteLine(dictionary["table"]);
            }
            if (isGlassContain)
            {
                Console.WriteLine(dictionary["glass"]);
            }

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Eskişehir");
            cities.Add("Afyon");

            //Console.WriteLine(cities.Contains("Afyon"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer {Id= 1,FirstName = "Murat" });
            //customers.Add(new Customer {Id= 2,FirstName = "Dilruba" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Murat" },
                new Customer { Id = 2, FirstName = "Dilruba" }
            };

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Melih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName ="Fatıma"},
                new Customer { Id = 5, FirstName = "Selamet"}
            });

            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();
            var index = customers.IndexOf(customer2);
            Console.WriteLine($"Index: {index}");

            customers.Add(customer2);
            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine($"Index: {lastIndex}");

            customers.Insert(0, customer2);

            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Melih");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer {customer.FirstName}");
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("Adana");
            cities.Add(2);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
