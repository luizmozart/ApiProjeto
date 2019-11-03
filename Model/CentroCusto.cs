using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class CentroCusto
    {
        public CentroCusto()
        {
            Pedido = new HashSet<Pedido>();
            Usuario = new HashSet<Usuario>();
        }

        public int CcuId { get; set; }
        public int? CcuCodigo { get; set; }
        public string CcuNome { get; set; }
        public int CliId { get; set; }

        public virtual Cliente Cli { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
