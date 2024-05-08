using PimProject.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Aggregates
{
    public class Produção : Entity
    {
        public string produto_id { get; set; }
        public string produto_produzido {  get; set; }




    }
}
