using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Pages.AlbumTypes
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public AlbumType AlbumType { get; set; }

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(Guid id)
        {
            AlbumType = _unitOfWork.AlbumType.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (AlbumType != null)
            {
                _unitOfWork.AlbumType.Remove(AlbumType);
                _unitOfWork.Save();
                TempData["success"] = "Album deleted successfully";
            }
            return RedirectToPage("Index");
        }
    }
}