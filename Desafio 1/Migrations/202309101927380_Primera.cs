namespace Desafio_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DUI = c.String(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        MontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Categoria = c.String(nullable: false, maxLength: 50),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departamento = c.String(nullable: false, maxLength: 50),
                        Municipio = c.String(nullable: false, maxLength: 50),
                        EncargadoSucursal = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Pedidoes", new[] { "ClienteId" });
            DropTable("dbo.Sucursals");
            DropTable("dbo.Productoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Clientes");
        }
    }
}
