using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1,Age = 24};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2} added!", customer.Id, customer.Name, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2} added!", customer.Id, customer.Name, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
