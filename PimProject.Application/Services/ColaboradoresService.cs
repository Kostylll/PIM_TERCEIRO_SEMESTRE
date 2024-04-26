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
        private readonly IColaboradoresRepository _colRepository;
  
        public ColaboradoresService(IColaboradoresRepository colRepository)
        {
            _colRepository = colRepository;
        }

        public ColaboradoresService()
        {

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

        public async Task<List<ColaboradoresResponse>> ExibirColaboradores()
        {
            var colaboradorViewList = new List<ColaboradoresResponse>();
            var colab = await _colRepository.GetAllAsync();

            foreach(var colabs in colab)
            {
                var colabViewModel = new ColaboradoresResponse();

                colabViewModel.Nome = colabs.Nome;
                colabViewModel.Sobrenome = colabs.Sobrenome;
                colabViewModel.Data_Nascimento = colabs.Data_Nascimento;
                colabViewModel.CPF = colabs.CPF;
                colabViewModel.Email = colabs.Email;

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
                colab.Nome = response.Nome;
                colab.Sobrenome = response.Sobrenome;
                colab.Data_Nascimento = response.Data_Nascimento;
                colab.CPF = response.CPF;
                colab.Email = response.Email;

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
