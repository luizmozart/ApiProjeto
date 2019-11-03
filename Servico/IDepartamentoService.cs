using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Servico
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetDepartamentoByEmpresa(int clienteId);
        Task<Departamento> GetDepartamentoByCod(int clienteId, int codigoDepartamento);
        Task<Departamento> AddDepartamento(Departamento departamento);
        Task<bool> UpdateDepartamento(Departamento departamento);
        Task<bool> DeleteDepartamento(int id);
    }
}
