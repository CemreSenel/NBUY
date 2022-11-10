using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;


namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void CreateCustomer(Customer customer);    // C-reate
        List<Customer> GetAllCustomer();         // R-ead
        Customer GetByIdCustomer(int id);
        void UpdateCustomer(Customer customer);    // U-pdate
        void DeleteCustomer(int id);             // D-elete
        List<Customer> GetPCustomersByCategory(string CategoryName);
    }
}