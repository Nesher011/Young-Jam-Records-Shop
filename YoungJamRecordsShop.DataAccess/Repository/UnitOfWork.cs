using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            AlbumType = new AlbumTypeRepository(_dbContext);
            CaseType = new CaseTypeRepository(_dbContext);
            Product = new ProductRepository(_dbContext);
        }

        public IAlbumTypeRepository AlbumType { get; private set; }
        public ICaseTypeRepository CaseType { get; private set; }
        public IProductRepository Product { get; private set; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}