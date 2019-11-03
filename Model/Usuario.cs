using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            PedidoUsuario = new HashSet<PedidoUsuario>();
        }

        public int UsuId { get; set; }
        public string UsuNome { get; set; }
        public string UsuCpf { get; set; }
        public int? UsuTipo { get; set; }
        public DateTime? UsuDataNascimento { get; set; }
        public string UsuMatricula { get; set; }
        public string UsuRg { get; set; }
        public string UsuOrgaoEmissor { get; set; }
        public string UsuEndereco { get; set; }
        public string UsuBairro { get; set; }
        public string UsuCidade { get; set; }
        public string UsuCep { get; set; }
        public string UsuUf { get; set; }
        public decimal? UsuSalario { get; set; }
        public int? UsuHabilitadoPedido { get; set; }
        public DateTime? UsuDataExcluido { get; set; }
        public int? UsuCodigoEscola { get; set; }
        public int? UsuCodigoAvulso { get; set; }
        public int? UsuCodigoSigom { get; set; }
        public int CliId { get; set; }
        public int? DepId { get; set; }
        public int? CcuId { get; set; }
        public decimal? UsuValorPedido { get; set; }
        public DateTime? UsuDataCadastro { get; set; }
        public DateTime? UsuDataAtualizacao { get; set; }

        public virtual CentroCusto Ccu { get; set; }
        public virtual Cliente Cli { get; set; }
        public virtual Departamento Dep { get; set; }
        public virtual ICollection<PedidoUsuario> PedidoUsuario { get; set; }
    }
}
