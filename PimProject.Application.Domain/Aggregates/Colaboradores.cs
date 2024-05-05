using PimProject.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Aggregates
{
    public class Colaboradores : Entity
    {
        public string Nome_Completo { get; set; }
        public string Email { get; set; }
        public string Data_Nascimento { get; set; }
        public string CPF { get; set; }
        public string Status { get; set; }
        public string Telefone { get; set; }

    }
}
