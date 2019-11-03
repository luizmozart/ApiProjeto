using System;
using System.Collections.Generic;

namespace ApiProjeto.Model
{
    public partial class Departamento
    {
        public Departamento()
        {
            Pedido = new HashSet<Pedido>();
            Usuario = new HashSet<Usuario>();
        }

        public int DepId { get; set; }
        public int? DepCodigo { get; set; }
        public string DepNome { get; set; }
        public int CliId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
