using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Repositorio.Implementacao
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        public Task<Pedido> AddPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePedido(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> GetPedidoByCodigo(int clienteId, string codigoPedido)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pedido>> GetPedidoByEmpresa(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
