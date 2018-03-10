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
    public class AliquotaICMSMap : EntityTypeConfiguration<AliquotaICMS>
    {
        public AliquotaICMSMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAliquotaICMS);
            this.Property(t => t.IdAliquotaICMS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            // Table & Column Mappings
            this.ToTable("AliquotaICMS");
            this.Property(t => t.IdAliquotaICMS).HasColumnName("IdAliquotaICMS");
            this.Property(t => t.IdEstado).HasColumnName("IdEstado");
            this.Property(t => t.Percentual).HasColumnName("Percentual");

            // Relationships
            //this.HasRequired(t => t.Estado)
            //    .WithMany(t => t.AliquotaICMS)
            //    .HasForeignKey(d => d.IdEstado);

        }
    }
}
