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
        Task<bool> AdicionarProdução(ProducoesResponse response);

        Task<bool> RemoverProdução(string id);

        Task<ProducoesResponse> AtualizarProdução(ProducoesResponse response, string id);

        Task<List<ProducoesResponse>> ExibirProdução();
    }
}
