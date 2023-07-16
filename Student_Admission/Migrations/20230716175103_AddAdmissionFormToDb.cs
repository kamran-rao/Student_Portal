using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Admission.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmissionFormToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissionForms",
                columns: table => new
                {
                    SNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    admissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionForms", x => x.SNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionForms");
        }
    }
}
