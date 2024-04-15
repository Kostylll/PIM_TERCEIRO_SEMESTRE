using PimProject.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Interface
{
    public interface IProduçãoServices
    {
        Task<bool> AdicionarProducao(ProducoesResponse response);

        Task<bool> RemoverProducao(string id);

        Task<ProducoesResponse> AtualizarProducao(ProducoesResponse response, string id);

        Task<List<ProducoesResponse>> ExibirProducoes();
    }
}
