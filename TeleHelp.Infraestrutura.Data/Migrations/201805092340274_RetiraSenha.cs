namespace TeleHelp.Infraestrutura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RetiraSenha : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "SenhaExtra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "SenhaExtra", c => c.Binary());
        }
    }
}
