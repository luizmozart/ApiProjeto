using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class PedidoUsuario
    {
        public int PusId { get; set; }
        public decimal? PusValor { get; set; }
        public string PusErro { get; set; }
        public DateTime? PusDataRecarga { get; set; }
        public decimal? PusValorRecarga { get; set; }
        public string PusLocalRecarga { get; set; }
        public int? PedId { get; set; }
        public int? UsuId { get; set; }
        public int? TarId { get; set; }

        public virtual Pedido Ped { get; set; }
        public virtual Usuario Usu { get; set; }
    }
}
