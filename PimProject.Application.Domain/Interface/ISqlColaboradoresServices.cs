using PimProject.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Interface
{
    public interface ISqlColaboradoresServices
    {
        Task<bool> AdicionarColaborador(ColaboradoresResponse response);

        Task<bool> AdicionarAsync(string sqlCommand, Dictionary<string, object> parameters);

        Task<List<ColaboradoresResponse>> ExibirColaboradores();
    }
}
