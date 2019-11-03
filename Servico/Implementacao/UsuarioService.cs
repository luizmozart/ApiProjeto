using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;

namespace ApiProjeto.Servico.Implementacao
{
    public class UsuarioService : IUsuarioService
    {
        public Task<Usuario> AddDepartamento(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetDepartamentoByCod(int clienteId, int codigoUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetUsuarioByEmpresa(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDepartamento(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
