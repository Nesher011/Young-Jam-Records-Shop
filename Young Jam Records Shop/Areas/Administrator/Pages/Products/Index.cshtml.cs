using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Product>? Products { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            Products = _unitOfWork.Product.GetAll(includeProperties: "AlbumType,CaseType");
        }
    }
}