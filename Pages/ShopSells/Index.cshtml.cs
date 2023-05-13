using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Linq;

namespace SupermarketWEB.Pages.ShopSells
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<ShopSell> ShopSells { get; set; } = default!;


        public async Task OnGetAsync()
        {

            if (_context.ShopSells != null)
            {
                ShopSells = await _context.ShopSells.ToListAsync();
            }
        }
    }
}
