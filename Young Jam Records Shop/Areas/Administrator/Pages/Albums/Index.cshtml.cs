using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Albums
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Album> Albums { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            Albums = _unitOfWork.Album.GetAll();
        }
    }
}