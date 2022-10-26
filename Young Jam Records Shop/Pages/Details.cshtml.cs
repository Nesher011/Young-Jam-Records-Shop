using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCart? cartObj;

        public DetailsModel(ILogger<DetailsModel> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public void OnGet(Guid id)
        {
            cartObj = new()
            {
                Count = 1,
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id, includeProperties: "AlbumType,CaseType")
            };
        }
    }
}