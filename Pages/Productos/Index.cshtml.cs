using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Producto> Productos { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Productos != null)
            {
                Productos = await _context.Productos.ToListAsync();
            }
        }
    }
}
