using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Repositorio
{
    public interface IPedidoRepositorio
    {
        Task<List<Pedido>> GetPedidoByEmpresa(int clienteId);
        Task<Pedido> GetPedidoByCodigo(int clienteId, string codigoPedido);
        Task<Pedido> AddPedido(Pedido pedido);
        Task<bool> UpdatePedido(Pedido pedido);
        Task<bool> DeletePedido(int id);
    }
}
