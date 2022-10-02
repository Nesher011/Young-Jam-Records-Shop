using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class AlbumTypeRepository : Repository<AlbumType>, IAlbumTypeRepository
    {
        private ApplicationDbContext _dbContext;

        public AlbumTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(AlbumType obj)
        {
            _dbContext.AlbumType.Update(obj);
        }
    }
}