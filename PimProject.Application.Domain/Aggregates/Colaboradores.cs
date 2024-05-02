using PimProject.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Aggregates
{
    public class Colaboradores:Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Data_Nascimento { get; set; }
        public string CPF { get; set; }

    }
}
