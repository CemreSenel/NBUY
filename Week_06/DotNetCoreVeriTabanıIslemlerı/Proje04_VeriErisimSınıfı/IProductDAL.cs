using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje04_VeriErisimSınıfı
{
    public interface IProductDAL
    {
        void CreateProduct(Product product); //C-reate
        List<Product>GetAllProducts();       //R-ead

        Product GetById(int id);

        void UpdateProduct(Product product); //U-pdate

        void DeleteProduct(Product product); //D-elete
    }
    public class SqlProductDAL : IProductDAL
    {
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public class MySqlProductDAL : IProductDAL


    {
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}