using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Repositorio
{
    public interface IDepartamentoRepositorio
    {
        Task<List<Departamento>> GetDepartamentoByEmpresa(int clienteId);
        Task<Departamento> GetDepartamentoByCodigo(int clienteId, int codigoDepartamento);
        Task<Departamento> AddDepartamento(Departamento departamento);
        Task<bool> UpdateDepartamento(Departamento departamento);
        Task<bool> DeleteDepartamento(int id);
    }
}
