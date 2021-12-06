using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using consumindo_api.Models;
using agenda_api_net_core.Repository;

namespace agenda_api_net_core.Pages.Pessoas
{
    public class CreateModel : PageModel
    {
        private readonly IPessoaRepository _pessoaService;

        public CreateModel(IPessoaRepository pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _pessoaService.PostPessoa(Pessoa);

            return RedirectToPage("./Index");
        }
    }
}
