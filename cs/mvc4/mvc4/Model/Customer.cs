using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomaszMatusiakLab4.Model
{
    public partial class Customer
    {
        public static List <Customer> GetAll (DataClasses1DataContext dataContext)
        {
            return dataContext.Customers.ToList();
        }
        public static List<Customer> GetByName(DataClasses1DataContext dataContext, string name)
        {
            var query = from customers in dataContext.Customers where customers._ContactName == name select customers;
            return query.ToList();
        }
    }
}
