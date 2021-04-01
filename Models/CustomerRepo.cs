using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class CustomerRepo : IRepo<Customer>
    {
        public List<Customer> customers { get; set; }

        public CustomerRepo()
        {
            customers = new List<Customer>()
            {
                new Customer
                {
                    Id=101,
                    Name = "Alex",
                    Age = 22

                }
            };
        }

        public void AddItem(Customer item)
        {
            //Logic her we can check id pereset
            customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}

