using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Servico
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetUsuarioByEmpresa(int clienteId);
        Task<Usuario> GetDepartamentoByCod(int clienteId, int codigoUsuario);
        Task<Usuario> AddDepartamento(Usuario usuario);
        Task<bool> UpdateDepartamento(Usuario usuario);
        Task<bool> DeleteUsuario(int id);
    }
}
