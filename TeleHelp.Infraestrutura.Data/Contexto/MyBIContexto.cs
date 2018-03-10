using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Infraestrutura.Data.Mapping;

namespace TeleHelp.Infraestrutura.Data.Contexto
{
    public class MyBIContexto : DbContext
    {
        public MyBIContexto() : base("MyBI")
        {
            Database.SetInitializer<MyBIContexto>(new CreateDatabaseIfNotExists<MyBIContexto>());
        }

        //public virtual DbSet<Bonificacao> Bonificacao { get; set; }
        //public virtual DbSet<BloqueioServico> BloqueioServico { get; set; }
        public virtual DbSet<Usuario> Usuarios{ get; set; }
        //public virtual DbSet<Banco> Bancos { get; set; }
        //public virtual DbSet<Categoria> Categorias { get; set; }
        //public virtual DbSet<Cep> Ceps { get; set; }
        //public virtual DbSet<Cidade> Cidades { get; set; }
        //public virtual DbSet<Cliente> Clientes { get; set; }
        //public virtual DbSet<Combo> Combos { get; set; }
        //public virtual DbSet<ComboServico> ComboServicos { get; set; }
        //public virtual DbSet<Servico> Servicos { get; set; }
        //public virtual DbSet<Cargo> Cargos { get; set; }
        //public virtual DbSet<AlergiaCliente> AlergiaClientes { get; set; }
        //public virtual DbSet<AliquotaICMS> AliquotaICMS { get; set; }
        //public virtual DbSet<Acao> Acoes { get; set; }
        //public virtual DbSet<Agenda> Agendas { get; set; }
        //public virtual DbSet<Alergia> Alergias { get; set; }
        //public virtual DbSet<AssistenciaMedica> AssistenciaMedicas { get; set; }
        //public virtual DbSet<Auditoria> Auditorias{ get; set; }
        //public virtual DbSet<ContaCliente> ContaClientes { get; set; }
        //public virtual DbSet<TipoEndereco> TipoEnderecos { get; set; }
        //public virtual DbSet<EnderecoCliente> EnderecoClientes { get; set; }
        //public virtual DbSet<Sistema> Sistemas { get; set; }
        //public virtual DbSet<Menu> Menus { get; set; }
        //public virtual DbSet<Tela> Telas { get; set; }
        //public virtual DbSet<MenuTela> MenuTelas { get; set; }
        //public virtual DbSet<Grupo> Grupos { get; set; }
        //public virtual DbSet<GrupoUsuario> GrupoUsuarios { get; set; }
        //public virtual DbSet<PermissaoTela> PermissaoTelas { get; set; }
        //public virtual DbSet<FuncionalidadeTela> FuncionalidadeTelas { get; set; }
        //public virtual DbSet<PermissaoFuncionalidade> PermissaoFuncionalidades { get; set; }
        //public virtual DbSet<Departamento> Departamentos { get; set; }
        
        ////2017-11-07 - EDSON FEITOSA
        //public virtual DbSet<RepresentanteUsuario> RepresentantesUsuarios { get; set; }
        //public virtual DbSet<Representante> Representantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                .HasMaxLength(100));

            //modelBuilder.Configurations.Add(new BonificacaoMap());
            //modelBuilder.Configurations.Add(new TipoEnderecoMap());
            //modelBuilder.Configurations.Add(new EnderecoClienteMap());
            //modelBuilder.Configurations.Add(new ClienteContaMap());
            //modelBuilder.Configurations.Add(new BloqueioServicoMap());
            //modelBuilder.Configurations.Add(new AuditoriaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            //modelBuilder.Configurations.Add(new AlergiaClienteMap());
            //modelBuilder.Configurations.Add(new ServicoMap());
            //modelBuilder.Configurations.Add(new ComboServicoMap());
            //modelBuilder.Configurations.Add(new ComboMap());
            //modelBuilder.Configurations.Add(new ClienteMap());
            //modelBuilder.Configurations.Add(new CidadeMap());
            //modelBuilder.Configurations.Add(new CepMap());
            //modelBuilder.Configurations.Add(new CategoriaMap());
            //modelBuilder.Configurations.Add(new BancoMap());
            //modelBuilder.Configurations.Add(new AssistenciaMedicaMap());
            //modelBuilder.Configurations.Add(new AlergiaMap());
            //modelBuilder.Configurations.Add(new AgendaMap());
            //modelBuilder.Configurations.Add(new AliquotaICMSMap());
            //modelBuilder.Configurations.Add(new AcaoMap());
            //modelBuilder.Configurations.Add(new CargoMap());

            ////Novos
            //modelBuilder.Configurations.Add(new SistemaMap());
            //modelBuilder.Configurations.Add(new MenuMap());
            //modelBuilder.Configurations.Add(new TelaMap());
            //modelBuilder.Configurations.Add(new MenuTelaMap());
            //modelBuilder.Configurations.Add(new GrupoMap());
            //modelBuilder.Configurations.Add(new GrupoUsuarioMap());
            //modelBuilder.Configurations.Add(new PermissaoTelaMap()); 
            //modelBuilder.Configurations.Add(new FuncionalidadeTelaMap()); 
            //modelBuilder.Configurations.Add(new PermissaoFuncionalidadeMap());
            //modelBuilder.Configurations.Add(new DepartamentoMap());
            //modelBuilder.Configurations.Add(new RepresentanteUsuarioMap());
            //modelBuilder.Configurations.Add(new RepresentanteMap());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    //TODO - Buscar informação da data atual do banco de dados
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }

    
}
