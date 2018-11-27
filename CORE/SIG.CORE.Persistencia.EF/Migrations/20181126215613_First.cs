using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIG.CORE.Persistencia.EF.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SEG_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    NombreNormalizado = table.Column<string>(maxLength: 30, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEG_Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(maxLength: 30, nullable: false),
                    NombreUsuarioNormalizado = table.Column<string>(maxLength: 30, nullable: true),
                    Correo = table.Column<string>(maxLength: 80, nullable: false),
                    CorreoNormalizado = table.Column<string>(maxLength: 80, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEG_PerfilesRol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdRol = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_PerfilesRol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SEG_PerfilesRol_SEG_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "SEG_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEG_LoginsUsuario",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    NombreProveedor = table.Column<string>(nullable: true),
                    IdUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_LoginsUsuario", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_SEG_LoginsUsuario_SEG_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "SEG_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEG_PerfilesUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_PerfilesUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SEG_PerfilesUsuario_SEG_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "SEG_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEG_RolesUsuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false),
                    IdRol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_RolesUsuario", x => new { x.IdUsuario, x.IdRol });
                    table.ForeignKey(
                        name: "FK_SEG_RolesUsuario_SEG_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "SEG_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SEG_RolesUsuario_SEG_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "SEG_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEG_TokensUsuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEG_TokensUsuario", x => new { x.IdUsuario, x.LoginProvider, x.Nombre });
                    table.ForeignKey(
                        name: "FK_SEG_TokensUsuario_SEG_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "SEG_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SEG_LoginsUsuario_IdUsuario",
                table: "SEG_LoginsUsuario",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_SEG_PerfilesRol_IdRol",
                table: "SEG_PerfilesRol",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_SEG_PerfilesUsuario_IdUsuario",
                table: "SEG_PerfilesUsuario",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "SEG_Roles",
                column: "NombreNormalizado",
                unique: true,
                filter: "[NombreNormalizado] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SEG_RolesUsuario_IdRol",
                table: "SEG_RolesUsuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "SEG_Usuarios",
                column: "CorreoNormalizado");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "SEG_Usuarios",
                column: "NombreUsuarioNormalizado",
                unique: true,
                filter: "[NombreUsuarioNormalizado] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SEG_LoginsUsuario");

            migrationBuilder.DropTable(
                name: "SEG_PerfilesRol");

            migrationBuilder.DropTable(
                name: "SEG_PerfilesUsuario");

            migrationBuilder.DropTable(
                name: "SEG_RolesUsuario");

            migrationBuilder.DropTable(
                name: "SEG_TokensUsuario");

            migrationBuilder.DropTable(
                name: "SEG_Roles");

            migrationBuilder.DropTable(
                name: "SEG_Usuarios");
        }
    }
}
