using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> GetUsuarioByEmpresa(int clienteId);
        Task<Usuario> GetUsuarioByCPF(int clienteId, string cpfUsuario);
        Task<Usuario> AddUsuario(Usuario usuario);
        Task<bool> UpdateUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(int id);
    }
}
