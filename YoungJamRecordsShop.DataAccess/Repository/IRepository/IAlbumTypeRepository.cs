using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IAlbumTypeRepository : IRepository<AlbumType>
    {
        void Update(AlbumType obj);
    }
}