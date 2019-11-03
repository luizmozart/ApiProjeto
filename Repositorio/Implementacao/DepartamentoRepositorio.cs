using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeto.Repositorio.Implementacao
{
    

    public class DepartamentoRepositorio : IDepartamentoRepositorio
    {
        private readonly ProjetoContext _contexto;
        public DepartamentoRepositorio(ProjetoContext contexto)
        {
            _contexto = contexto;
        }
        public Task<Departamento> AddDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Departamento> GetDepartamentoByCodigo(int clienteId, int codigoDepartamento)
        {
            try
            {
                return await _contexto.Departamento.SingleOrDefaultAsync(d => d.CliId == clienteId && d.DepCodigo == codigoDepartamento);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Departamento>> GetDepartamentoByEmpresa(int clienteId)
        {
            try
            {
                return await _contexto.Departamento.AsNoTracking().Where(d => d.CliId == clienteId).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Task<bool> UpdateDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}
