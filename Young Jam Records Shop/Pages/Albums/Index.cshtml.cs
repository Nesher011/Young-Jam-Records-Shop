using Microsoft.AspNetCore.Mvc.RazorPages;
using Young_Jam_Records_Shop.Data;
using Young_Jam_Records_Shop.Model;

namespace Young_Jam_Records_Shop.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public IEnumerable<Album> Albums { get; set; }

        public IndexModel(ApplicationDbContext dbContext)

        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Albums = _dbContext.Album;
        }
    }
}