using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        parentId = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Guests",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Phone = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Guests", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OrderNumber = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        Voided = table.Column<bool>(nullable: false),
            //        TotalPrice = table.Column<double>(nullable: false),
            //        PaidAmount = table.Column<double>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Status",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Status", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UnitTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitTypes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(nullable: true),
            //        Password = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GuestTables",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Phone = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        StatusId = table.Column<int>(nullable: true),
            //        GuestId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GuestTables", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GuestTables_Guests_GuestId",
            //            column: x => x.GuestId,
            //            principalTable: "Guests",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GuestTables_Status_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Status",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Units",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        UnitTypeId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Units", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Units_UnitTypes_UnitTypeId",
            //            column: x => x.UnitTypeId,
            //            principalTable: "UnitTypes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Item",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Price = table.Column<double>(nullable: false),
            //        Discount = table.Column<double>(nullable: false),
            //        Quantity = table.Column<int>(nullable: false),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        UnitId = table.Column<int>(nullable: true),
            //        CategoryId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Item", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Item_Categories_CategoryId",
            //            column: x => x.CategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Item_Units_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "Units",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemImage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Data = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        Itemid = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemImage", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ItemImage_Item_Itemid",
            //            column: x => x.Itemid,
            //            principalTable: "Item",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderItems",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        Created = table.Column<DateTime>(nullable: false),
            //        Updated = table.Column<DateTime>(nullable: false),
            //        Deleted = table.Column<bool>(nullable: false),
            //        Voided = table.Column<bool>(nullable: false),
            //        SalePrice = table.Column<double>(nullable: false),
            //        Itemid = table.Column<int>(nullable: true),
            //        OrderId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItems", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Item_Itemid",
            //            column: x => x.Itemid,
            //            principalTable: "Item",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Orders_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Orders",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_GuestId",
            //    table: "GuestTables",
            //    column: "GuestId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_StatusId",
            //    table: "GuestTables",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_CategoryId",
            //    table: "Item",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_UnitId",
            //    table: "Item",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemImage_Itemid",
            //    table: "ItemImage",
            //    column: "Itemid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_Itemid",
            //    table: "OrderItems",
            //    column: "Itemid");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_OrderId",
            //    table: "OrderItems",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Units_UnitTypeId",
            //    table: "Units",
            //    column: "UnitTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "GuestTables");

            //migrationBuilder.DropTable(
            //    name: "ItemImage");

            //migrationBuilder.DropTable(
            //    name: "OrderItems");

            //migrationBuilder.DropTable(
            //    name: "Roles");

            //migrationBuilder.DropTable(
            //    name: "Users");

            //migrationBuilder.DropTable(
            //    name: "Guests");

            //migrationBuilder.DropTable(
            //    name: "Status");

            //migrationBuilder.DropTable(
            //    name: "Item");

            //migrationBuilder.DropTable(
            //    name: "Orders");

            //migrationBuilder.DropTable(
            //    name: "Categories");

            //migrationBuilder.DropTable(
            //    name: "Units");

            //migrationBuilder.DropTable(
            //    name: "UnitTypes");
        }
    }
}
