using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class GrupoMap : EntityTypeConfiguration<Grupo>
    {
        public GrupoMap()
        {
            // Primary Key
            this.HasKey(g => g.IdGrupo);
            this.Property(g => g.IdGrupo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(g => g.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            this.Property(g => g.Nome)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_GRUPO")
                      {
                          IsUnique = true,
                          Order = 1
                      }));

            // Table & Column Mappings
            this.ToTable("Grupo");
            this.Property(t => t.IdGrupo).HasColumnName("IdGrupo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
