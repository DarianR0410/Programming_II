using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LogIn");

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "LogIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentAccount",
                schema: "LogIn",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentAccount", x => x.AccountNumber);
                    table.ForeignKey(
                        name: "FK_CurrentAccount_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalSchema: "LogIn",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingAccount",
                schema: "LogIn",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingAccount", x => x.AccountNumber);
                    table.ForeignKey(
                        name: "FK_SavingAccount_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalSchema: "LogIn",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAccount_IdCustomer",
                schema: "LogIn",
                table: "CurrentAccount",
                column: "IdCustomer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccount_IdCustomer",
                schema: "LogIn",
                table: "SavingAccount",
                column: "IdCustomer",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentAccount",
                schema: "LogIn");

            migrationBuilder.DropTable(
                name: "SavingAccount",
                schema: "LogIn");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "LogIn");
        }
    }
}
