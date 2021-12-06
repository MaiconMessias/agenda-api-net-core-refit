using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using consumindo_api.Models;
using agenda_api_net_core.Repository;

namespace agenda_api_net_core.Pages.Pessoas
{
    public class EditModel : PageModel
    {
        private readonly IPessoaRepository _pessoaService;

        public EditModel(IPessoaRepository pessoaService)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _pessoaService.PutPessoa(Pessoa.Id, Pessoa);

            /*_context.Attach(Pessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(Pessoa.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }*/

            return RedirectToPage("./Index");
        }

       /* private bool PessoaExists(int id)
        {
            return _context.Pessoa.Any(e => e.Id == id);
        }*/
    }
}
