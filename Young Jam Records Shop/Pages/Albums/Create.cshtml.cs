using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages.Albums
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Album Album { get; set; }

        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _dbContext.Album.AddAsync(Album);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Album added successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}