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
    public class GrupoUsuarioMap : EntityTypeConfiguration<GrupoUsuario>
    {
        public GrupoUsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdGrupoUsuario);
            this.Property(t => t.IdGrupoUsuario)
                           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.Property(g => g.IdGrupo)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_GRUPOUSUARIO")
                      {
                          IsUnique = true,
                          Order = 1
                      }));

            this.Property(g => g.IdUsuario)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_GRUPOUSUARIO")
                      {
                          IsUnique = true,
                          Order = 2
                      }));

            // Properties
            // Table & Column Mappings
            this.ToTable("GrupoUsuario");
            this.Property(t => t.IdGrupoUsuario).HasColumnName("IdGrupoUsuario");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.DataFim).HasColumnName("DataFim");
            this.Property(t => t.IdGrupo).HasColumnName("IdGrupo");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");

            // Relationships
            //this.HasRequired(t => t.Grupo)
            //    .WithMany(t => t.GrupoUsuario)
            //    .HasForeignKey(d => d.IdGrupo);

            //this.HasRequired(t => t.Usuario)
            //    .WithMany(t => t.GrupoUsuario)
            //    .HasForeignKey(d => d.IdUsuario);

        }
    }
}
