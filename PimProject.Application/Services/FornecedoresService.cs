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
            var forn = new Vendas()
            {
                nome_empresa = response.nome_empresa,
                quantidade = response.quantidade,
                valor = response.valor,
                nome_produto = response.nome_produto,
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

                fornViewModel.nome_empresa = forns.nome_empresa;
                fornViewModel.quantidade = forns.quantidade;
                fornViewModel.valor = forns.valor;
                fornViewModel.nome_produto = forns.nome_produto;

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
                forn.nome_empresa = response.nome_empresa;
                forn.quantidade = response.quantidade;
                forn.valor = response.valor;
                forn.nome_produto = response.nome_produto;


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
