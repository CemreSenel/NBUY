using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    
    public class SqlCustomerDAL :ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString ="Server:DESKTOP-OFVK2FD"
        }
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer GetByIdCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetPCustomersByCategory(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

       
    }
}