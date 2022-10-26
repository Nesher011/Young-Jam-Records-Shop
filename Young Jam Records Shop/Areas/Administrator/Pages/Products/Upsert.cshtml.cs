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
        public List<SelectListItem>? CaseTypeList { get; set; }
        public List<SelectListItem>? AlbumTypeList { get; set; }

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Product? Product { get; set; }

        public UpsertModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet(Guid? id)
        {
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
                Product = new();
            }
            else
            {
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
                //update
            }
        }

        public async Task<IActionResult> OnPost(IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\products");
                    var extension = Path.GetExtension(file.FileName);

                    if (Product.CoverImageUrl != null)
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, Product.CoverImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    Product.CoverImageUrl = @"images\products\" + fileName + extension;
                }
                if (_unitOfWork.Product.GetFirstOrDefault(u => u.Id == Product.Id) == null)
                {
                    _unitOfWork.Product.Add(Product);
                }
                else
                {
                    _unitOfWork.Product.Update(Product);
                }
                _unitOfWork.Save();
                TempData["success"] = "Album added successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}