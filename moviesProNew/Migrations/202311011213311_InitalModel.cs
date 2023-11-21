﻿namespace moviesProNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CName = c.String(),
                })
                .PrimaryKey(t => t.Id)
                ;

        }

        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
