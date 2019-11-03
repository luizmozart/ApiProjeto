using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class Pedido
    {
        public Pedido()
        {
            PusPedidoUsuario = new HashSet<PedidoUsuario>();
        }

        public int PedId { get; set; }
        public int? PedTipo { get; set; }
        public decimal? PedValor { get; set; }
        public decimal? PedValorPago { get; set; }
        public decimal? PedValorErro { get; set; }
        public DateTime? PedPeriodoInicial { get; set; }
        public DateTime? PedPeriodoFinal { get; set; }
        public DateTime? PedDataCadastro { get; set; }
        public DateTime? PedDataExclusao { get; set; }
        public DateTime? PedDataConfirmado { get; set; }
        public DateTime? PedDataAnalise { get; set; }
        public DateTime? PedDataProcessado { get; set; }
        public DateTime? PedDataBoletoImpresso { get; set; }
        public DateTime? PedDataHabilitado { get; set; }
        public DateTime? PedDataVencimento { get; set; }
        public DateTime? PedDataPagamento { get; set; }
        public string PedReferencia { get; set; }
        public string PedNossoNumero { get; set; }
        public string PedNotaCredito { get; set; }
        public int? CliId { get; set; }
        public int? DepId { get; set; }
        public int? CcuId { get; set; }
        public int? CatId { get; set; }
        public string PedArquivoBanco { get; set; }

        public virtual CentroCusto Ccu { get; set; }
        public virtual Cliente Cli { get; set; }
        public virtual Departamento Dep { get; set; }
        public virtual ICollection<PedidoUsuario> PusPedidoUsuario { get; set; }
    }
}
