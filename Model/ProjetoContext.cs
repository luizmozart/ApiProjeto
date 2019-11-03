using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiProjeto.Model
{
    public partial class ProjetoContext : DbContext
    {
        public ProjetoContext()
        {
        }

        public ProjetoContext(DbContextOptions<ProjetoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CentroCusto> CentroCusto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoUsuario> PedidoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EIL115B;Initial Catalog=Projeto;User ID=sa;Password=kbce63y");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CentroCusto>(entity =>
            {
                entity.HasKey(e => e.CcuId);

                entity.ToTable("CCU_CENTRO_CUSTO");

                entity.Property(e => e.CcuId).HasColumnName("ccu_id");

                entity.Property(e => e.CcuCodigo).HasColumnName("ccu_codigo");

                entity.Property(e => e.CcuNome)
                    .HasColumnName("ccu_nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CliId).HasColumnName("cli_id");

                entity.HasOne(d => d.Cli)
                    .WithMany(p => p.CentroCusto)
                    .HasForeignKey(d => d.CliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCU_CENTRO_CUSTO_CLI_CLIENTE");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CliId);

                entity.ToTable("CLI_CLIENTE");

                entity.Property(e => e.CliId)
                    .HasColumnName("cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CliBairro)
                    .HasColumnName("cli_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliCep)
                    .HasColumnName("cli_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CliCidade)
                    .HasColumnName("cli_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliCnpj)
                    .HasColumnName("cli_cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CliCnpjLibercard)
                    .HasColumnName("cli_cnpj_libercard")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CliContato)
                    .HasColumnName("cli_contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliContratoLibercard)
                    .HasColumnName("cli_contrato_libercard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CliDataUltimoAcesso)
                    .HasColumnName("cli_data_ultimo_acesso")
                    .HasColumnType("datetime");

                entity.Property(e => e.CliEmail)
                    .HasColumnName("cli_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CliEndereco)
                    .HasColumnName("cli_endereco")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CliFone)
                    .HasColumnName("cli_fone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliLiberadoAcesso).HasColumnName("cli_liberado_acesso");

                entity.Property(e => e.CliLiberadoCaucaia).HasColumnName("cli_liberado_caucaia");

                entity.Property(e => e.CliLiberadoConvenioEstudante).HasColumnName("cli_liberado_convenio_estudante");

                entity.Property(e => e.CliLiberadoJuazeiro).HasColumnName("cli_liberado_juazeiro");

                entity.Property(e => e.CliLiberadoMaracanau).HasColumnName("cli_liberado_maracanau");

                entity.Property(e => e.CliLiberadoMetropolitano).HasColumnName("cli_liberado_metropolitano");

                entity.Property(e => e.CliLiberadoUrbano).HasColumnName("cli_liberado_urbano");

                entity.Property(e => e.CliNome)
                    .HasColumnName("cli_nome")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CliSenha)
                    .HasColumnName("cli_senha")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CliTipoPagamento).HasColumnName("cli_tipo_pagamento");

                entity.Property(e => e.CliUf)
                    .HasColumnName("cli_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.ToTable("DEP_DEPARTAMENTO");

                entity.Property(e => e.DepId).HasColumnName("dep_id");

                entity.Property(e => e.CliId).HasColumnName("cli_id");

                entity.Property(e => e.DepCodigo).HasColumnName("dep_codigo");

                entity.Property(e => e.DepNome)
                    .HasColumnName("dep_nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Departamento)
                    .HasForeignKey(d => d.CliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEP_DEPARTAMENTO_CLI_CLIENTE");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.PedId);

                entity.ToTable("PED_PEDIDO");

                entity.Property(e => e.PedId).HasColumnName("ped_id");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CcuId).HasColumnName("ccu_id");

                entity.Property(e => e.CliId).HasColumnName("cli_id");

                entity.Property(e => e.DepId).HasColumnName("dep_id");

                entity.Property(e => e.PedArquivoBanco)
                    .HasColumnName("ped_arquivo_banco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PedDataAnalise)
                    .HasColumnName("ped_data_analise")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataBoletoImpresso)
                    .HasColumnName("ped_data_boleto_impresso")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataCadastro)
                    .HasColumnName("ped_data_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataConfirmado)
                    .HasColumnName("ped_data_confirmado")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataExclusao)
                    .HasColumnName("ped_data_exclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataHabilitado)
                    .HasColumnName("ped_data_habilitado")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataPagamento)
                    .HasColumnName("ped_data_pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataProcessado)
                    .HasColumnName("ped_data_processado")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDataVencimento)
                    .HasColumnName("ped_data_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedNossoNumero)
                    .HasColumnName("ped_nosso_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PedNotaCredito)
                    .HasColumnName("ped_nota_credito")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PedPeriodoFinal)
                    .HasColumnName("ped_periodo_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedPeriodoInicial)
                    .HasColumnName("ped_periodo_inicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedReferencia)
                    .HasColumnName("ped_referencia")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PedTipo)
                    .HasColumnName("ped_tipo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PedValor)
                    .HasColumnName("ped_valor")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PedValorErro)
                    .HasColumnName("ped_valor_erro")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PedValorPago)
                    .HasColumnName("ped_valor_pago")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ccu)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.CcuId)
                    .HasConstraintName("FK_PED_PEDIDO_CCU_CENTRO_CUSTO");

                entity.HasOne(d => d.Cli)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.CliId)
                    .HasConstraintName("FK_PED_PEDIDO_CLI_CLIENTE");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_PED_PEDIDO_DEP_DEPARTAMENTO");
            });

            modelBuilder.Entity<PedidoUsuario>(entity =>
            {
                entity.HasKey(e => e.PusId);

                entity.ToTable("PUS_PEDIDO_USUARIO");

                entity.Property(e => e.PusId).HasColumnName("pus_id");

                entity.Property(e => e.PedId).HasColumnName("ped_id");

                entity.Property(e => e.PusDataRecarga)
                    .HasColumnName("pus_data_recarga")
                    .HasColumnType("datetime");

                entity.Property(e => e.PusErro)
                    .HasColumnName("pus_erro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PusLocalRecarga)
                    .HasColumnName("pus_local_recarga")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PusValor)
                    .HasColumnName("pus_valor")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PusValorRecarga)
                    .HasColumnName("pus_valor_recarga")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TarId).HasColumnName("tar_id");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");

                entity.HasOne(d => d.Ped)
                    .WithMany(p => p.PusPedidoUsuario)
                    .HasForeignKey(d => d.PedId)
                    .HasConstraintName("FK_PUS_PEDIDO_USUARIO_PED_PEDIDO");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.PedidoUsuario)
                    .HasForeignKey(d => d.UsuId)
                    .HasConstraintName("FK_PUS_PEDIDO_USUARIO_USU_USUARIO");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId);

                entity.ToTable("USU_USUARIO");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");

                entity.Property(e => e.CcuId).HasColumnName("ccu_id");

                entity.Property(e => e.CliId).HasColumnName("cli_id");

                entity.Property(e => e.DepId).HasColumnName("dep_id");

                entity.Property(e => e.UsuBairro)
                    .HasColumnName("usu_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCep)
                    .HasColumnName("usu_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCidade)
                    .HasColumnName("usu_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCodigoAvulso).HasColumnName("usu_codigo_avulso");

                entity.Property(e => e.UsuCodigoEscola).HasColumnName("usu_codigo_escola");

                entity.Property(e => e.UsuCodigoSigom).HasColumnName("usu_codigo_sigom");

                entity.Property(e => e.UsuCpf)
                    .HasColumnName("usu_cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UsuDataAtualizacao)
                    .HasColumnName("usu_data_atualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuDataCadastro)
                    .HasColumnName("usu_data_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuDataExcluido)
                    .HasColumnName("usu_data_excluido")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuDataNascimento)
                    .HasColumnName("usu_data_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuEndereco)
                    .HasColumnName("usu_endereco")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UsuHabilitadoPedido).HasColumnName("usu_habilitado_pedido");

                entity.Property(e => e.UsuMatricula)
                    .HasColumnName("usu_matricula")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UsuNome)
                    .HasColumnName("usu_nome")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UsuOrgaoEmissor)
                    .HasColumnName("usu_orgao_emissor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuRg)
                    .HasColumnName("usu_rg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuSalario)
                    .HasColumnName("usu_salario")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuTipo).HasColumnName("usu_tipo");

                entity.Property(e => e.UsuUf)
                    .HasColumnName("usu_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UsuValorPedido)
                    .HasColumnName("usu_valor_pedido")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ccu)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CcuId)
                    .HasConstraintName("FK_USU_USUARIO_CCU_CENTRO_CUSTO");

                entity.HasOne(d => d.Cli)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USU_USUARIO_CLI_CLIENTE");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_USU_USUARIO_DEP_DEPARTAMENTO");
            });
        }
    }
}
