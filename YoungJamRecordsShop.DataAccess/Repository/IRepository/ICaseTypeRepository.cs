using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface ICaseTypeRepository : IRepository<CaseType>
    {
        void Update(CaseType obj);
    }
}