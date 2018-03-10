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
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCliente);
            this.Property(t => t.IdCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.RazaoSocial)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.InscricaoEstadual)
                .HasMaxLength(14);

            this.Property(t => t.CpfCnpj)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.Rg)
                .HasMaxLength(14);

            this.Property(t => t.Imagem)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            this.Property(t => t.InscricaoEstadual).HasColumnName("InscricaoEstadual");
            this.Property(t => t.DataNascimento).HasColumnName("DataNascimento");
            this.Property(t => t.CpfCnpj).HasColumnName("CpfCnpj");
            this.Property(t => t.Rg).HasColumnName("Rg");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            this.Property(t => t.Genero).HasColumnName("Genero");
            this.Property(t => t.EstadoCivil).HasColumnName("EstadoCivil");
            this.Property(t => t.IdTipoCliente).HasColumnName("IdTipoCliente");
            this.Property(t => t.IdTipoPessoa).HasColumnName("IdTipoPessoa");
            this.Property(t => t.IdTipoParentesco).HasColumnName("IdTipoParentesco");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdClienteAdicional).HasColumnName("IdClienteAdicional");
            this.Property(t => t.IdDeposito).HasColumnName("IdDeposito");
            this.Property(t => t.IdIndicacao).HasColumnName("IdIndicacao");
            this.Property(t => t.Imagem).HasColumnName("Imagem");

            // Relationships
            this.HasOptional(t => t.ClienteAdicional)
                .WithMany()
                .HasForeignKey(d => d.IdClienteAdicional);

            //this.HasOptional(t => t.Deposito)
            //    .WithMany(t => t.Cliente)
            //    .HasForeignKey(d => d.IdDeposito);
            //this.HasOptional(t => t.Indicacao)
            //    .WithMany(t => t.Cliente)
            //    .HasForeignKey(d => d.IdIndicacao);

        }
    }
}
