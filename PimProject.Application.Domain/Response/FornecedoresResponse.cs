using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Response
{
    public class FornecedoresResponse
    {
        public string Nome_Empresa { get; set; }
        public string Quantidade { get; set; }
        public string Valor { get; set; }
        public string Nome_Produto { get; set; }
        public string CNPJ { get; set; }
    }
}
