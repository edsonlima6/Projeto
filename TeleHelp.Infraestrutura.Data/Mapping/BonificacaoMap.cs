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
    public class BonificacaoMap : EntityTypeConfiguration<Bonificacao>
    {
        public BonificacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdBonificacao);
            this.Property(t => t.IdBonificacao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Bonificacao");
            this.Property(t => t.IdBonificacao).HasColumnName("IdBonificacao");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.TipoBonificacao).HasColumnName("TipoBonificacao");
            this.Property(t => t.Periodo).HasColumnName("Periodo");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
