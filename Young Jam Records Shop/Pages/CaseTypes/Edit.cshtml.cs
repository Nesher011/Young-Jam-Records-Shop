using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess.Repository.IRepository;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages.CaseTypes
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public CaseType CaseType { get; set; }

        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(int id)
        {
            CaseType = _unitOfWork.CaseType.GetFirstOrDefault(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CaseType.Update(CaseType);
                _unitOfWork.Save();
                TempData["success"] = "Case Type edited successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}