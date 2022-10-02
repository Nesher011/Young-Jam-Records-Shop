using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Pages.AlbumTypes
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<AlbumType> AlbumTypes { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            AlbumTypes = _unitOfWork.AlbumType.GetAll();
        }
    }
}