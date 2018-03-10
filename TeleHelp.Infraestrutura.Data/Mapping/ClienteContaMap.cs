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
    public class ClienteContaMap : EntityTypeConfiguration<ContaCliente>
    {
        public ClienteContaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdContaCliente);
            this.Property(t => t.IdContaCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContaCliente");
            this.Property(t => t.IdContaCliente).HasColumnName("IdContaCliente");
            this.Property(t => t.TipoConta).HasColumnName("TipoConta");
            this.Property(t => t.Agencia).HasColumnName("Agencia");
            this.Property(t => t.NumeroCartao).HasColumnName("NumeroCartao");
            this.Property(t => t.Conta).HasColumnName("Conta");
            this.Property(t => t.DataValidade).HasColumnName("DataValidade");
            this.Property(t => t.DiaCobranca).HasColumnName("DiaCobranca");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdBanco).HasColumnName("IdBanco");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");

            // Relationships
            this.HasRequired(t => t.Banco)
                .WithMany(t => t.ContaCliente)
                .HasForeignKey(d => d.IdBanco);

            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.ContaCliente)
                .HasForeignKey(d => d.IdCliente);

        }
    }
}
