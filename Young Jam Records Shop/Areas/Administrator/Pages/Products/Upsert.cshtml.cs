using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Areas.Administrator.Pages.Products
{
    [BindProperties]
    public class UpsertModel : PageModel
    {
        public List<SelectListItem> CaseTypeList { get; set; }
        public List<SelectListItem> AlbumTypeList { get; set; }

        private readonly IUnitOfWork _unitOfWork;
        public Product Product { get; set; }

        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(Guid? id)
        {
            Product product = new();
            CaseTypeList = _unitOfWork.CaseType.GetAll().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Name
            }).ToList();

            AlbumTypeList = _unitOfWork.AlbumType.GetAll().Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.AlbumFormat
            }).ToList();

            if (id == null)
            {
                //create
            }
            else
            {
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
                //update
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(Product);
                _unitOfWork.Save();
                TempData["success"] = "Album edited successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}