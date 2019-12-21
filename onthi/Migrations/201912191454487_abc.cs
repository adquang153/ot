namespace onthi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDanhBas",
                c => new
                    {
                        TenGoi = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        SDT = c.String(),
                        TenNhom = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenGoi)
                .ForeignKey("dbo.NhomDanhBas", t => t.TenNhom)
                .Index(t => t.TenNhom);
            
            CreateTable(
                "dbo.NhomDanhBas",
                c => new
                    {
                        TenNhom = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNhom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDanhBas", "TenNhom", "dbo.NhomDanhBas");
            DropIndex("dbo.ChiTietDanhBas", new[] { "TenNhom" });
            DropTable("dbo.NhomDanhBas");
            DropTable("dbo.ChiTietDanhBas");
        }
    }
}
