using PimProject.Application.Abstraction.Repository;
using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Infra.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Infra.Data.Repository
{
    public class ProduçãoRepository : Repository<Produção>, IProduçãoRepository
    {
        public ProduçãoRepository(PimProjectDbContext context): base(context) { }
    }
}
