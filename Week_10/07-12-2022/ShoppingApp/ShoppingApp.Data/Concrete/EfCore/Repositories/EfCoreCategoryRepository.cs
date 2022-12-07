using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Context;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context) : base(context)
        {
            //Buraya gelen context base class a gonderılıyor ve aynı zamanda sadece bu constructor ıcınde gecerlı.Ama bu
            //classın butununde henuz kullanılamıyor.Eger kullanısın ıstesek yapmamız gereken ıslemler var
        }

        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
