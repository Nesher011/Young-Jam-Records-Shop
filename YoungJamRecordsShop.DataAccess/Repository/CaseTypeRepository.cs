using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess.Repository
{
    public class CaseTypeRepository : Repository<CaseType>, ICaseTypeRepository
    {
        private ApplicationDbContext _dbContext;

        public CaseTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(CaseType obj)
        {
            _dbContext.CaseType.Update(obj);
        }
    }
}