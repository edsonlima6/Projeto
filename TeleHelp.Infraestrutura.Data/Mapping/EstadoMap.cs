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
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            HasKey(d => d.IdEstado);
            this.Property(d => d.IdEstado)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(d => d.Nome)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_ESTADO")
                      {
                          IsUnique = true
                      }));

            Property(d => d.Nome)
                .IsRequired();

            Property(d => d.IdPais)
                .IsOptional();




        }
    }
}
