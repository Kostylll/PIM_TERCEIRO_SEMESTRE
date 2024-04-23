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
    public class VendasService : IVendasServices
    {
        private readonly PimProjectDbContext _context;
        private readonly IVendasRepository _venRepository;

        public VendasService()
        {
        }

        public VendasService(IVendasRepository venRepository, PimProjectDbContext context)
        {
            _context = context;
            _venRepository = venRepository;
        }

        public async Task<bool> AdicionarVenda(VendasResponse response)
        {
            var vend = new Vendas()
            {
                valor_venda = response.valor_venda,
            };

            await _venRepository.AddAsync(vend);
            await _venRepository.SaveChangesAsync();



            return true;
        }

        public async Task<List<VendasResponse>> ExibirVendas()
        {
            var vendaViewList = new List<VendasResponse>();
            var vend = await _venRepository.GetAllAsync();

            foreach (var vends in vend)
            {
                var vendViewModel = new VendasResponse();

                vendViewModel.valor_venda = vends.valor_venda;

                vendaViewList.Add(vendViewModel);

            }
            return vendaViewList;
        }

        public async Task<bool> RemoverVenda(string id)
        {
            var vendId = await _venRepository.GetByIdAsync(id);
            _venRepository.Delete(vendId);
            await _venRepository.SaveChangesAsync();
            return true;

        }


        public async Task<VendasResponse> AtualizarVenda(VendasResponse response, string id)
        {
            var vend = await _venRepository.GetByIdAsync(id);

            if (vend != null)
            {
                vend.valor_venda = response.valor_venda;

                _venRepository.Update(vend);
                await _venRepository.SaveChangesAsync();

            }

            else
            {
                return null;
            }

            return response;


        }

    }
}
