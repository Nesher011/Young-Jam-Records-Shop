using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Pages.Products
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Product Product { get; set; }

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(Guid id)
        {
            Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (Product != null)
            {
                _unitOfWork.Product.Remove(Product);
                _unitOfWork.Save();
                TempData["success"] = "Album deleted successfully";
            }
            return RedirectToPage("Index");
        }
    }
}