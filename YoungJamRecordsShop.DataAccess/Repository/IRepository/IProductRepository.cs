using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        bool Any(Expression<Func<Product, bool>> filter);

        void Update(Product obj);
    }
}