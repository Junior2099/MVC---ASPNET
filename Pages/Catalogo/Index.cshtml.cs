using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PI.Data;
using PI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PI.Pages
{
    public class CatalogoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CatalogoModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produtos { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos
                .Where(p => p.EmEstoque == true) // Corrigido para usar comparação booleana
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }
    }
}
