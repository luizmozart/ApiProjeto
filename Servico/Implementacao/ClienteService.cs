using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;

namespace ApiProjeto.Servico.Implementacao
{
    public class ClienteService : IClienteService
    {
        public Task<Cliente> AddCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetClienteByCod(int clienteId, int codigoCliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> GetClienteByEmpresa(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
