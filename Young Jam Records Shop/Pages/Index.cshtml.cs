using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Product>? ProductList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            ProductList = _unitOfWork.Product.GetAll(includeProperties: "AlbumType,CaseType");
        }
    }
}