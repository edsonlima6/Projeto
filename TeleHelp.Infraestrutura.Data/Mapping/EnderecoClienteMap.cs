using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class EnderecoClienteMap : EntityTypeConfiguration<EnderecoCliente>
    {
        public EnderecoClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEnderecoCliente);
            this.Property(t => t.IdEnderecoCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Endereco)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Complemento)
                .HasMaxLength(40);

            this.Property(t => t.Bairro)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Cidade)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.CEP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UF)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("EnderecoCliente");
            this.Property(t => t.IdEnderecoCliente).HasColumnName("IdEnderecoCliente");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Complemento).HasColumnName("Complemento");
            this.Property(t => t.Numero).HasColumnName("Numero");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.CEP).HasColumnName("CEP");
            this.Property(t => t.UF).HasColumnName("UF");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            this.Property(t => t.IdTipoEndereco).HasColumnName("IdTipoEndereco");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");

            // Relationships
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.EnderecoCliente)
                .HasForeignKey(d => d.IdCliente);

            HasRequired(ec => ec.TipoEndereco)
                .WithMany(tp => tp.EnderecoCliente)
                .HasForeignKey(ec => ec.IdTipoEndereco);

        }
    }
}
