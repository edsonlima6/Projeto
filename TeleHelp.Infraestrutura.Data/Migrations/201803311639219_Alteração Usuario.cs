namespace TeleHelp.Infraestrutura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraçãoUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "Turno");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Turno", c => c.Int());
        }
    }
}
