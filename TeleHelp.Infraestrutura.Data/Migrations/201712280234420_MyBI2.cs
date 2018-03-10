namespace TeleHelp.Infraestrutura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyBI2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Foto = c.Binary(),
                        Matricula = c.Int(),
                        Turno = c.Int(),
                        HorarioEntrada = c.Time(precision: 7),
                        HorarioSaida = c.Time(precision: 7),
                        IdTipoUsuario = c.Int(nullable: false),
                        IdTipoAtendimento = c.Int(nullable: false),
                        Email = c.String(maxLength: 120, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        IdCargo = c.Int(nullable: false),
                        IdDepartamento = c.Int(nullable: false),
                        Login = c.String(maxLength: 100, unicode: false),
                        Senha = c.Binary(),
                        SenhaExtra = c.Binary(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .Index(t => new { t.Email, t.Nome, t.Login }, unique: true, name: "UN_Usuario");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "UN_Usuario");
            DropTable("dbo.Usuario");
        }
    }
}
