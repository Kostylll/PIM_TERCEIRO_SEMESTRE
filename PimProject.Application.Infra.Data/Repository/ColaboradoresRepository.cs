using PimProject.Application.Abstraction.Repository;
using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Infra.Data.DBContext;


namespace PimProject.Application.Infra.Data.Repository
{
    public class ColaboradoresRepository : Repository<Colaboradores>, IColaboradoresRepository
    {
        public ColaboradoresRepository(PimProjectDbContext context) : base(context) { }
    }
}
