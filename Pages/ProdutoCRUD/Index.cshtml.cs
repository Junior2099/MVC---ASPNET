using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PI.Data;
using PI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PI.Pages.ProdutoCRUD
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produtos { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}