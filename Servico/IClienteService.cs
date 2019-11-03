using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Servico
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetClienteByEmpresa(int clienteId);
        Task<Cliente> GetClienteByCod(int clienteId, int codigoCliente);
        Task<Cliente> AddCliente(Cliente cliente);
        Task<bool> UpdateCliente(Cliente cliente);
        Task<bool> DeleteCliente(int id);
    }
}
