using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class CargoMap : EntityTypeConfiguration<Cargo>
    {
        public CargoMap()
        {
            HasKey(ca => ca.IdCargo);

            ToTable("Cargo");

            this.Property(d => d.Nome)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_CARGO")
                      {
                          IsUnique = true,
                          Order = 1
                      }));

        }
    }
}
