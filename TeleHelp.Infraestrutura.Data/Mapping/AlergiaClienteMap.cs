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
    public class AlergiaClienteMap : EntityTypeConfiguration<AlergiaCliente>
    {
        public AlergiaClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAlergiaCliente);
            this.Property(t => t.IdAlergiaCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Observacao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AlergiaCliente");
            this.Property(t => t.IdAlergiaCliente).HasColumnName("IdAlergiaCliente");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.IdAlergia).HasColumnName("IdAlergia");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.Observacao).HasColumnName("Observacao");

            // Relationships
            this.HasRequired(t => t.Alergia)
                .WithMany(t => t.AlergiaCliente)
                .HasForeignKey(d => d.IdAlergia);
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.AlergiaCliente)
                .HasForeignKey(d => d.IdCliente);

        }
    }
}
