namespace TeleHelp.Infraestrutura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "Matricula");
            DropColumn("dbo.Usuario", "HorarioEntrada");
            DropColumn("dbo.Usuario", "HorarioSaida");
            DropColumn("dbo.Usuario", "IdTipoUsuario");
            DropColumn("dbo.Usuario", "IdTipoAtendimento");
            DropColumn("dbo.Usuario", "IdCargo");
            DropColumn("dbo.Usuario", "IdDepartamento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "IdDepartamento", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "IdCargo", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "IdTipoAtendimento", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "IdTipoUsuario", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "HorarioSaida", c => c.Time(precision: 7));
            AddColumn("dbo.Usuario", "HorarioEntrada", c => c.Time(precision: 7));
            AddColumn("dbo.Usuario", "Matricula", c => c.Int());
        }
    }
}
