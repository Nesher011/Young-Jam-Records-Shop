using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Any(Expression<Func<Product, bool>> filter)
        {
            IQueryable<Product> query = dbSet;
            return query.Any();
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            var objFromDb = _dbContext.Product.FirstOrDefault(u => u.Id == obj.Id);

            objFromDb.Author = obj.Author;
            objFromDb.AlbumType = obj.AlbumType;
            objFromDb.AlbumTypeId = obj.AlbumTypeId;
            objFromDb.ListPrice = obj.ListPrice;
            objFromDb.EAN = obj.EAN;
            objFromDb.Price = obj.Price;
            objFromDb.CaseType = obj.CaseType;
            objFromDb.CaseTypeId = obj.CaseTypeId;
            objFromDb.Description = obj.Description;
            objFromDb.Title = obj.Title;

            if (obj.CoverImageUrl != null)
            {
                objFromDb.CoverImageUrl = obj.CoverImageUrl;
            }

            _dbContext.Product.Update(objFromDb);
        }
    }
}