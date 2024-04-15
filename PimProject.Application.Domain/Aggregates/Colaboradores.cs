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
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string data_nascimento { get; set; }
        public string cpf { get; set; }

    }
}
