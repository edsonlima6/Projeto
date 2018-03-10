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
    public class RepresentanteMap : EntityTypeConfiguration<Representante>
    {
        public RepresentanteMap()
        {
            HasKey(r => r.IdRepresentante);
            Property(r => r.IdRepresentante)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("Representante");
            this.Property(r => r.RazaoSocial)
                    .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_RAZAO_CNPJ")
                    {
                        IsUnique = true,
                        Order = 1
                    }));
            this.Property(r => r.CNPJ)
                  .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_RAZAO_CNPJ")
                  {
                      IsUnique = true,
                      Order = 2
                  }));

            Property(r => r.Endereco)
                .IsRequired()
                .HasMaxLength(120);
            Property(r => r.Cidade).IsRequired();
            Property(r => r.Bairro).IsRequired();
            Property(r => r.CEP).IsRequired();

        }
    }
}
