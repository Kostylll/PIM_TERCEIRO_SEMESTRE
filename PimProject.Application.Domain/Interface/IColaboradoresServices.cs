using PimProject.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Interface
{
    public interface IColaboradoresServices
    {
        Task<bool> AdicionarColaborador(ColaboradoresResponse response);



    }
}
