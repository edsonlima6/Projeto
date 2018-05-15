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
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUsuario);
            this.Property(t => t.IdUsuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Email)
                .HasMaxLength(120);

            this.Property(u => u.Senha).IsOptional();

            this.Property(t => t.Email)
                       .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_Usuario")
                       {
                           IsUnique = true,
                           Order = 1
                       }));
            this.Property(t => t.Nome)
                       .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_Usuario")
                       {
                           IsUnique = true,
                           Order = 2
                       }));
            this.Property(t => t.Login)
                       .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_Usuario")
                       {
                           IsUnique = true,
                           Order = 3
                       }));

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.Foto).HasColumnName("Foto");
            //this.Property(t => t.Turno).HasColumnName("Turno");
            //this.Property(t => t.IdTipoPerfil).HasColumnName("IdTipoPerfil");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Senha).HasColumnName("Senha");
            //this.Property(t => t.SenhaExtra).HasColumnName("SenhaExtra");
            this.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");


            // Relationships
            //this.HasRequired(t => t.Cargo)
            //    .WithMany(t => t.Usuario)
            //    .HasForeignKey(d => d.IdCargo);

            //this.HasRequired(t => t.Departamento)
            //    .WithMany(t => t.Usuario)
            //    .HasForeignKey(d => d.IdDepartamento);

        }
    }
}
