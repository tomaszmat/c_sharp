using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tomaszMatusiakLab4.Model;

namespace tomaszMatusiakLab4
{
    public partial class FormMain : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public FormMain()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// Przycisk pobierający bazę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGet_Click(object sender, EventArgs e)
        {
            var query = Customer.GetAll(dataContext);
            //var query = from customer in dataContext.Customers select customer;
            ////var query = from customer in dataContext.Customers select new { customer.City };
            dataGridViewContent.DataSource = query.ToList();
        }
        /// <summary>
        /// Przycisk wyświetlający dany element.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List <Customer> client = (from customer in dataContext.Customers select customer).Where(x => x.City == "Berlin").ToList();
            //Customer client = (from customer in dataContext.Customers where client.City == "Berlin" ).All(); error
            //Customer client = (from customer in dataContext.Customers select customer).First();
            //Customer client = (from customer in dataContext.Customers select customer).All();
            //jeśli nie ma takiej potrzeby to nie używamy VAR; (jak najmniej);
           //client.City = "Wrocław";
            //client.City = "Koło";
            //dataContext.SubmitChanges();
            //zapytania lambda? -> dzialaja tez na kolekcjach;
            dataGridViewContent.DataSource = client;
        }
        /// <summary>
        /// Przycisk dodawający.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ContactName = textBoxName.Text;
            customer.CustomerID = textBoxID.Text;
            customer.CompanyName = textBoxCompanyName.Text;
            customer.Country = "Lipa";
            customer.Fax = " 909";
            dataContext.Customers.InsertOnSubmit(customer);
            dataContext.SubmitChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var client = (from customer in dataContext.Customers select customer).Where(x => x.City == "London").First();
            dataContext.Customers.DeleteOnSubmit(client);
            dataContext.SubmitChanges();
        }

        private void buttonShowCustomerOrders_Click(object sender, EventArgs e)
        {
            var query = from customer in dataContext.Customers join order in dataContext.Orders on customer.CustomerID equals order.CustomerID select new { Klient = customer.ContactName, Zamowieniedata = order.OrderDate };
           // == = equals
            dataGridViewContent.DataSource = query;

        } 

    }
}
