using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Servico
{
    public interface IPedidoService
    {
        Task<List<Pedido>> GetPedidoByEmpresa(int clienteId);
        Task<Pedido> GetPedidoByCod(int clienteId, int codigoPedido);
        Task<Pedido> AddDepartamento(Pedido pedido);
        Task<bool> UpdateDepartamento(Pedido pedido);
        Task<bool> DeletePedido(int id);
    }
}
