using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IAlbumRepository : IRepository<Album>
    {
        void Update(Album obj);
    }
}