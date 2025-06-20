using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();
        public void GenerateSampleDataset()
        {
            customers.Add(new Customer() { Id = 1, Name = "sinh", Phone = "2-32-7899" });
            customers.Add(new Customer() { Id = 2, Name = "hai", Phone = "8-12-7896" });
            customers.Add(new Customer() { Id = 3, Name = "thong", Phone = "3-64-7894" });
            customers.Add(new Customer() { Id = 4, Name = "an", Phone = "6-97-789" });
            customers.Add(new Customer() { Id = 5, Name = "ca", Phone = "123-65-78" });

        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
