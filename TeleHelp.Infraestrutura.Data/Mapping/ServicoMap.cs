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
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdServico);
            this.Property(t => t.IdServico)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Servico");
            this.Property(t => t.IdServico).HasColumnName("IdServico");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.ValorMensal).HasColumnName("ValorMensal");
            this.Property(t => t.ValorAnual).HasColumnName("ValorAnual");
            this.Property(t => t.IdTipoServico).HasColumnName("IdTipoServico");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
