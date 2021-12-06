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
    public class IndexModel : PageModel
    {
        private readonly IPessoaRepository _pessoaService;

        public IndexModel(IPessoaRepository pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IList<Pessoa> Pessoas { get;set; }

        public async Task OnGetAsync()
        {
            Pessoas = await _pessoaService.GetPessoasAsync();
        }
    }
}
