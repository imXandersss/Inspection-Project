using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InspectionAPI.Migrations
{
    public partial class terceramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_InspectionType_inspectionTypeId",
                table: "Inspections");

            migrationBuilder.RenameColumn(
                name: "inspectionTypeId",
                table: "Inspections",
                newName: "inspectionTypeid");

            migrationBuilder.RenameIndex(
                name: "IX_Inspections_inspectionTypeId",
                table: "Inspections",
                newName: "IX_Inspections_inspectionTypeid");

            migrationBuilder.AlterColumn<int>(
                name: "inspectionTypeid",
                table: "Inspections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idInspectionType",
                table: "Inspections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_InspectionType_inspectionTypeid",
                table: "Inspections",
                column: "inspectionTypeid",
                principalTable: "InspectionType",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_InspectionType_inspectionTypeid",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "idInspectionType",
                table: "Inspections");

            migrationBuilder.RenameColumn(
                name: "inspectionTypeid",
                table: "Inspections",
                newName: "inspectionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Inspections_inspectionTypeid",
                table: "Inspections",
                newName: "IX_Inspections_inspectionTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "inspectionTypeId",
                table: "Inspections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_InspectionType_inspectionTypeId",
                table: "Inspections",
                column: "inspectionTypeId",
                principalTable: "InspectionType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
