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
    public class RepresentanteUsuarioMap : EntityTypeConfiguration<RepresentanteUsuario>
    {
        public RepresentanteUsuarioMap()
        {
            HasKey(ru => ru.IdRepresentanteUsuario);
            Property(ru => ru.IdRepresentanteUsuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(d => d.IdUsuario)
                     .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_REPRESENTANTEUSUARIO")
                     {
                         IsUnique = true,
                         Order = 1
                     }));

            this.Property(d => d.IdRepresentante)
                   .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_REPRESENTANTEUSUARIO")
                   {
                       IsUnique = true,
                       Order = 2
                   }));

            ToTable("RepresentanteUsuario");

            //HasRequired(ru => ru.Representante)
            //    .WithMany(r => r.RepresentanteUsuario)
            //    .HasForeignKey(r => r.IdRepresentante);

            //HasRequired(ru => ru.Usuario)
            //    .WithMany(r => r.RepresentanteUsuario)
            //    .HasForeignKey(r => r.IdUsuario);

        }
    }
}
