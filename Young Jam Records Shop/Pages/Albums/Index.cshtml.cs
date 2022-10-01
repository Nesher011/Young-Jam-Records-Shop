using Microsoft.AspNetCore.Mvc.RazorPages;
using YoungJamRecordsShop.DataAccess;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShopWeb.Pages.Albums
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