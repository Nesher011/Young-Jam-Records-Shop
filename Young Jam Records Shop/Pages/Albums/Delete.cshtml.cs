using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using Young_Jam_Records_Shop.Data;
using Young_Jam_Records_Shop.Model;

namespace Young_Jam_Records_Shop.Pages.Albums
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Album Album { get; set; }

        public DeleteModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(int id)
        {
            Album = _dbContext.Album.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (Album != null)
            {
                _dbContext.Album.Remove(Album);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = "Album deleted successfully";
            }
            return RedirectToPage("Index");
        }
    }
}