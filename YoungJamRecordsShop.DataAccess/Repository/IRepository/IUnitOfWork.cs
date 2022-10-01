namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAlbumRepository Album { get; }

        ICaseTypeRepository CaseType { get; }

        void Save();
    }
}