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
                nome = response.nome,
                sobrenome = response.sobrenome,
                email = response.email,
                data_nascimento = response.data_nascimento,
                cpf = response.cpf,

            };

            await _colRepository.AddAsync(colab);
            await _colRepository.SaveChangesAsync();



            return true;
        }

        public async Task<List<ColaboradoresResponse>> ExibirColaboradores()
        {
            var colaboradorViewList = new List<ColaboradoresResponse>();
            var colab = await _colRepository.GetAllAsync();

            foreach(var colabs in colab)
            {
                var colabViewModel = new ColaboradoresResponse();

                colabViewModel.nome = colabs.nome;
                colabViewModel.sobrenome = colabs.sobrenome;
                colabViewModel.data_nascimento = colabs.data_nascimento;
                colabViewModel.cpf = colabs.cpf;
                colabViewModel.email = colabs.email;

               colaboradorViewList.Add(colabViewModel);

            }
            return colaboradorViewList;
        }

        public async Task<bool> RemoverColaborador(string id)
        {
           var colabId = await _colRepository.GetByIdAsync(id);
           _colRepository.Delete(colabId); 
            await _colRepository.SaveChangesAsync();    
            return true;

        }


        public async Task<ColaboradoresResponse> AtualizarColaborador (ColaboradoresResponse response, string id)
        {
            var colab = await _colRepository.GetByIdAsync(id);

            if(colab != null)
            {
                colab.nome = response.nome;
                colab.sobrenome = response.sobrenome;
                colab.data_nascimento = response.data_nascimento;
                colab.cpf = response.cpf;
                colab.email = response.email;

                  _colRepository.Update(colab);
                  await _colRepository.SaveChangesAsync();

            }

            else
            {
                return null;
            }

            return response;


        }

    }
}
