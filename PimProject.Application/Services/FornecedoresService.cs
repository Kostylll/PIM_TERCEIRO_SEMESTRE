using Azure;
using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.DBContext;
using PimProject.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Services
{
    public class FornecedoresService : IFornecedoresServices
    {
        private readonly PimProjectDbContext _context;
        private readonly IFornecedoresRepository _forRepository;

        public FornecedoresService()
        {
        }

        public FornecedoresService(IFornecedoresRepository forRepository, PimProjectDbContext context)
        {
            _context = context;
            _forRepository = forRepository;
        }

        public async Task<bool> AdicionarFornecedor(FornecedoresResponse response)
        {
            var forn = new Fornecedores()
            {
                Nome_Empresa = response.Nome_Empresa,
                Quantidade = response.Quantidade,
                Valor = response.Valor,
                Nome_Produto = response.Nome_Produto,
            };

            await _forRepository.AddAsync(forn);
            await _forRepository.SaveChangesAsync();



            return true;
        }

        public async Task<List<FornecedoresResponse>> ExibirFornecedores()
        {
            var forneViewList = new List<FornecedoresResponse>();
            var forn = await _forRepository.GetAllAsync();

            foreach (var forns in forn)
            {
                var fornViewModel = new FornecedoresResponse();

                fornViewModel.Nome_Empresa = forns.Nome_Empresa;
                fornViewModel.Quantidade = forns.Quantidade;
                fornViewModel.Valor = forns.Valor;
                fornViewModel.Nome_Produto = forns.Nome_Produto;

                forneViewList.Add(fornViewModel);

            }
            return forneViewList;
        }

        public async Task<bool> RemoverFornecedor(string id)
        {
            var fordId = await _forRepository.GetByIdAsync(id);
            _forRepository.Delete(fordId);
            await _forRepository.SaveChangesAsync();
            return true;

        }


        public async Task<FornecedoresResponse> AtualizarFornecedor(FornecedoresResponse response, string id)
        {
            var forn = await _forRepository.GetByIdAsync(id);

            if (forn != null)
            {
                forn.Nome_Empresa = response.Nome_Empresa;
                forn.Quantidade = response.Quantidade;
                forn.Valor = response.Valor;
                forn.Nome_Produto = response.Nome_Produto;


                _forRepository.Update(forn);
                await _forRepository.SaveChangesAsync();

            }

            else
            {
                return null;
            }

            return response;


        }

    }
}
