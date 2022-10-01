using YoungJamRecordsShop.DataAccess.Repository.IRepository;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Album = new AlbumRepository(_dbContext);
            CaseType = new CaseTypeRepository(_dbContext);
        }

        public IAlbumRepository Album { get; private set; }
        public ICaseTypeRepository CaseType { get; private set; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}