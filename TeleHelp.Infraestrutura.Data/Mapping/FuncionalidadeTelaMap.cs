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
    public class FuncionalidadeTelaMap : EntityTypeConfiguration<FuncionalidadeTela>
    {
        public FuncionalidadeTelaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFuncionalidade);
            this.Property(t => t.IdFuncionalidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FuncionalidadeTela");
            this.Property(t => t.IdFuncionalidade).HasColumnName("IdFuncionalidade");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdTela).HasColumnName("IdTela");

            // Relationships
            this.HasRequired(t => t.Tela)
                .WithMany(t => t.FuncionalidadeTela)
                .HasForeignKey(d => d.IdTela);

        }
    }
}
