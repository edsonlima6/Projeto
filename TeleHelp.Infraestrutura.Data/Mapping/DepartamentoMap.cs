
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class DepartamentoMap : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMap()
        {
            HasKey(d => d.IdDepartamento);
            this.Property(d => d.IdDepartamento)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(d => d.Nome)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_DEPTOCONS")
                      {
                          IsUnique = true
                      }));

            Property(d => d.Ativo)
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
