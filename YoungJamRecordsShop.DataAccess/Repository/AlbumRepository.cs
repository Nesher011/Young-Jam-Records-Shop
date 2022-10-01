using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        private ApplicationDbContext _dbContext;

        public AlbumRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Album obj)
        {
            _dbContext.Album.Update(obj);
        }
    }
}