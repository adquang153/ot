namespace onthi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiTietDanhBas", "DiaChi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChiTietDanhBas", "DiaChi");
        }
    }
}
