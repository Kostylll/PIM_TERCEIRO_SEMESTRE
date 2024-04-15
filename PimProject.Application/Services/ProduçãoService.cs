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
    public class ProduçãoService : IProduçãoServices
    {
        private readonly PimProjectDbContext _context;
        private readonly IProduçãoRepository _proRepository;

        public ProduçãoService()
        {
        }

        public ProduçãoRepository(IProduçãoRepository proRepository, PimProjectDbContext context)
        {
            _context = context;
            _proRepository = proRepository;
        }

        public async Task<bool> AdicionarProdução(ProduçãoResponse response)
        {
            var prod = new Vendas()
            {
                produto_pro = response.produto_pro,
            };

            await _proRepository.AddAsync(prod);
            await _proRepository.SaveChangesAsync();



            return true;
        }

        public async Task<List<VendasResponse>> ExibirProdução()
        {
            var produViewList = new List<ProduçãoResponse>();
            var prod = await _proRepository.GetAllAsync();

            foreach (var prods in prod)
            {
                var prodViewModel = new VendasResponse();

                prodViewModel.produto_pro = prods.produto_pro;

                produViewList.Add(prodViewModel);

            }
            return produViewList;
        }

        public async Task<bool> RemoverProdução(string id)
        {
            var prodId = await _proRepository.GetByIdAsync(id);
            _proRepository.Delete(prodId);
            await _proRepository.SaveChangesAsync();
            return true;

        }


        public async Task<ProduçãoResponse> AtualizarVenda(ProduçãoResponse response, string id)
        {
            var prod = await _proRepository.GetByIdAsync(id);

            if (prod != null)
            {
                prod.produto_pro = response.produto_pro;

                _proRepository.Update(prod);
                await _proRepository.SaveChangesAsync();

            }

            else
            {
                return null;
            }

            return response;


        }

    }
}
