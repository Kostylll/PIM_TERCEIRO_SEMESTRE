using PimProject.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Interface
{
    public interface IVendasServices
    {
        Task<bool> AdicionarVenda(VendasResponse response);

        Task<bool> RemoverVenda(string id);

        Task<VendasResponse> AtualizarVenda(VendasResponse response, string id);

        Task<List<VendasResponse>> ExibirVendas();

    }
}
