using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;

namespace ApiProjeto.Repositorio.Implementacao
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Task<Usuario> AddUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuarioByCPF(int clienteId, string cpfUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetUsuarioByEmpresa(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
