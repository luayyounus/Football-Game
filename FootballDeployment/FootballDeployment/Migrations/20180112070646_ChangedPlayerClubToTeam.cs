using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballDeployment.Migrations
{
    public partial class ChangedPlayerClubToTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Club",
                table: "Players",
                newName: "Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Team",
                table: "Players",
                newName: "Club");
        }
    }
}
