using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public class CustomerRepository : IRepo<Customer>
    {
        List<Customer> customers;
        public CustomerRepository()
        {
            customers = new List<Customer> {

                new Customer { Id = 101, Name = "thejas", Age = 23 }
                };
        }
        public void AddItem(Customer item)
        {
            customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
