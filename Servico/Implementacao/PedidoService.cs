using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;

namespace ApiProjeto.Servico.Implementacao
{
    public class PedidoService : IPedidoService
    {
        public Task<Pedido> AddDepartamento(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePedido(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> GetPedidoByCod(int clienteId, int codigoPedido)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pedido>> GetPedidoByEmpresa(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDepartamento(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
