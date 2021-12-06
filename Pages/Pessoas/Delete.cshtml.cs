using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using consumindo_api.Models;
using agenda_api_net_core.Repository;

namespace agenda_api_net_core.Pages.Pessoas
{
    public class DeleteModel : PageModel
    {
        private readonly IPessoaRepository _pessoaService;

        public DeleteModel(IPessoaRepository pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa = await _pessoaService.GetPessoaByIdAsync(id ?? 0);


            if (Pessoa == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            Pessoa = await _context.Pessoa.FindAsync(id);

            if (Pessoa != null)
            {
                _context.Pessoa.Remove(Pessoa);
                await _context.SaveChangesAsync();
            }*/
            
            //await _pessoaService.DeletePessoa(id ?? 0);
            await _pessoaService.DeletePessoa(id ?? 0);

            return RedirectToPage("./Index");
        }
    }
}
