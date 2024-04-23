using PimProject.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Aggregates
{
    public class Fornecedores : Entity
    {
        public string Nome_Empresa {  get; set; }
        public string Quantidade { get; set; }
        public string Valor {get; set; }
        public string Nome_Produto { get; set; }

    }
}
