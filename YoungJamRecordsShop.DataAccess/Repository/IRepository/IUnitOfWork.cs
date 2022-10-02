namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAlbumTypeRepository AlbumType { get; }

        ICaseTypeRepository CaseType { get; }

        IProductRepository Product { get; }

        void Save();
    }
}