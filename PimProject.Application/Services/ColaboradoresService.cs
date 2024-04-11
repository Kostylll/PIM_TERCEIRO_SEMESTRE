using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.DBContext;
using PimProject.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Services
{
    public class ColaboradoresService : IColaboradoresServices
    {
        private readonly PimProjectDbContext _context;
        private readonly IColaboradoresRepository _colRepository;

        public ColaboradoresService()
        {
        }

        public ColaboradoresService(IColaboradoresRepository colRepository, PimProjectDbContext context)
        {
            _context = context;
            _colRepository = colRepository;
        }

        public async Task<bool> AdicionarColaborador(ColaboradoresResponse response)
        {
            var colab = new Colaboradores()
            {
                Nome = response.Nome,
                Sobrenome = response.Sobrenome,
                Email = response.Email,
                Data_Nascimento = response.Data_Nascimento,
                CPF = response.CPF,

            };

            await _colRepository.AddAsync(colab);
            await _colRepository.SaveChangesAsync();



            return true;
        }


    }
}
