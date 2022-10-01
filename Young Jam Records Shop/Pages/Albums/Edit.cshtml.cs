using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using YoungJamRecordsShop.DataAccess;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages.Albums
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Album Album { get; set; }

        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(int id)
        {
            Album = _dbContext.Album.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _dbContext.Album.Update(Album);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Album edited successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}