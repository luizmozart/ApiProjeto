using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class Cliente
    {
        public Cliente()
        {
            CentroCusto = new HashSet<CentroCusto>();
            Departamento = new HashSet<Departamento>();
            Pedido = new HashSet<Pedido>();
            Usuario = new HashSet<Usuario>();
        }

        public int CliId { get; set; }
        public string CliNome { get; set; }
        public string CliCnpj { get; set; }
        public string CliSenha { get; set; }
        public string CliEmail { get; set; }
        public string CliEndereco { get; set; }
        public string CliBairro { get; set; }
        public string CliCidade { get; set; }
        public string CliCep { get; set; }
        public string CliUf { get; set; }
        public string CliFone { get; set; }
        public string CliContato { get; set; }
        public int? CliTipoPagamento { get; set; }
        public DateTime? CliDataUltimoAcesso { get; set; }
        public int? CliLiberadoAcesso { get; set; }
        public int? CliLiberadoUrbano { get; set; }
        public int? CliLiberadoMetropolitano { get; set; }
        public int? CliLiberadoCaucaia { get; set; }
        public int? CliLiberadoMaracanau { get; set; }
        public int? CliLiberadoJuazeiro { get; set; }
        public int? CliLiberadoConvenioEstudante { get; set; }
        public string CliContratoLibercard { get; set; }
        public string CliCnpjLibercard { get; set; }

        public virtual ICollection<CentroCusto> CentroCusto { get; set; }
        public virtual ICollection<Departamento> Departamento { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
