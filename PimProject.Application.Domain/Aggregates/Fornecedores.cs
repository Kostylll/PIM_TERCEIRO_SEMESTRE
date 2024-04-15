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
        public string nome_empresa {  get; set; }
        public string quantidade { get; set; }
        public string valor {get; set; }
        public string nome_produto { get; set; }

    }
}
