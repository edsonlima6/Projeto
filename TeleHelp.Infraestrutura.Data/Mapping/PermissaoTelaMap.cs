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
    public class PermissaoTelaMap : EntityTypeConfiguration<PermissaoTela>
    {
        public PermissaoTelaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPermissaoTela);
            this.Property(t => t.IdPermissaoTela)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.IdGrupo)
                        .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_GrupoTela")
                        {
                            IsUnique = true,
                            Order = 1
                        }));

            this.Property(t => t.IdTela)
                        .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_GrupoTela")
                        {
                            IsUnique = true,
                            Order = 2
                        }));


            // Table & Column Mappings
            this.ToTable("GrupoTela");
            this.Property(t => t.IdPermissaoTela).HasColumnName("IdGrupoTela");
            this.Property(t => t.IdGrupo).HasColumnName("IdGrupo");
            this.Property(t => t.IdTela).HasColumnName("IdTela");
            this.Property(t => t.Incluir).HasColumnName("Incluir");
            this.Property(t => t.Alterar).HasColumnName("Alterar");
            this.Property(t => t.Excluir).HasColumnName("Excluir");
            this.Property(t => t.Consultar).HasColumnName("Consultar");

            HasRequired(t => t.Grupo).WithMany(c => c.PermissaoTela).HasForeignKey(t => t.IdGrupo);
            HasRequired(t => t.Tela).WithMany(c => c.PermissaoTela).HasForeignKey(t => t.IdTela);
        }
    }
}
