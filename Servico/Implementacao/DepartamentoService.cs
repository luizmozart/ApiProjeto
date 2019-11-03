using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Model;
using ApiProjeto.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeto.Servico.Implementacao
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepositorio _departamentoRepositorio;
        private readonly ProjetoContext _contexto;

        public DepartamentoService(IDepartamentoRepositorio departamentoRepositorio, ProjetoContext contexto)
        {
            _departamentoRepositorio = departamentoRepositorio;
            _contexto = contexto;
        }

        public Task<Departamento> AddDepartamento(Departamento departamento)
        {
            //verificando se o código do departamento já está cadastrado
            var codigo = _contexto.Departamento.SingleOrDefault(d => d.CliId == departamento.CliId && d.DepCodigo == departamento.DepCodigo);
            if (!string.IsNullOrEmpty(codigo.DepNome))
            {
                throw new ArgumentException("Código do departamento informado já existe " + codigo.DepCodigo.ToString());
            }

            return _departamentoRepositorio.AddDepartamento(departamento);
        }

        public Task<bool> DeleteDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Departamento> GetDepartamentoByCod(int clienteId, int codigoDepartamento)
        {
            var departamento = await _contexto.Departamento
                .Where(d => d.CliId == clienteId && d.DepCodigo == codigoDepartamento).FirstOrDefaultAsync();
            if (departamento == null)
            {
                throw new ArgumentException("Código do departamento informado não cadastrado " + codigoDepartamento.ToString());
            }

            return await _departamentoRepositorio.GetDepartamentoByCodigo(clienteId, codigoDepartamento);
        }

        public async Task<List<Departamento>> GetDepartamentoByEmpresa(int clienteId)
        {
            var result = await _contexto.Departamento.Where(d => d.CliId == clienteId).ToListAsync();
            if (result == null)
            {
                throw new ArgumentException("Código cliente informado não cadastrado " + clienteId.ToString());
            }

            return await _departamentoRepositorio.GetDepartamentoByEmpresa(clienteId);
        }

        public Task<bool> UpdateDepartamento(Departamento departamento)
        {
            var result = _contexto.Departamento.SingleOrDefault(d => d.DepId == departamento.DepId);
            if (result == null)
            {
                throw new ArgumentException("Código departamento informado não cadastrado ");
            }

            return _departamentoRepositorio.UpdateDepartamento(departamento);
        }
    }
}
