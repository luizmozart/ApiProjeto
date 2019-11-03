using ApiProjeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjeto.Repositorio
{
    public interface ICentroCustoRepositorio
    {
        Task<List<CentroCusto>> GetPedidoByEmpresa(int clienteId);
        Task<CentroCusto> GetCentroCustoByCodigo(int clienteId, string codigoCentroCusto);
        Task<CentroCusto> AddCentroCusto(CentroCusto centroCusto);
        Task<bool> UpdateCentroCusto(CentroCusto centroCusto);
        Task<bool> DeleteCentroCusto(int id);
    }
}
