using System.Collections.Generic;
using System.Threading.Tasks;
using consumindo_api.Models;
using Refit;

namespace agenda_api_net_core.Repository
{
    public interface IPessoaRepository
    {
        [Get("/api/pessoa")]
        Task<List<Pessoa>> GetPessoasAsync();

        [Get("/api/pessoa/{id}")]
        Task<Pessoa> GetPessoaByIdAsync(int id);

        [Put("/api/pessoa/{id}")]
        Task PutPessoa(int id, Pessoa pessoa);

        [Post("/api/pessoa")]
        Task PostPessoa(Pessoa pessoa);  

        [Delete("/api/pessoa/{id}")]      
        Task DeletePessoa(int id);        
    }

}