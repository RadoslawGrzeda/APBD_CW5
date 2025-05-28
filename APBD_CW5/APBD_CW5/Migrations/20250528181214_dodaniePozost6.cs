using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_CW5.Migrations
{
    /// <inheritdoc />
    public partial class dodaniePozost6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescritpionMedicaments_Medicaments_IdMedicament",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_IdPrescription",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescritpionMedicaments",
                table: "PrescritpionMedicaments");

            migrationBuilder.RenameTable(
                name: "PrescritpionMedicaments",
                newName: "Prescritpion_Medicament");

            migrationBuilder.RenameIndex(
                name: "IX_PrescritpionMedicaments_IdMedicament",
                table: "Prescritpion_Medicament",
                newName: "IX_Prescritpion_Medicament_IdMedicament");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescritpion_Medicament",
                table: "Prescritpion_Medicament",
                columns: new[] { "IdPrescription", "IdMedicament" });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescritpion_Medicament_Medicaments_IdMedicament",
                table: "Prescritpion_Medicament",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescritpion_Medicament_Prescriptions_IdPrescription",
                table: "Prescritpion_Medicament",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescripton",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescritpion_Medicament_Medicaments_IdMedicament",
                table: "Prescritpion_Medicament");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescritpion_Medicament_Prescriptions_IdPrescription",
                table: "Prescritpion_Medicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescritpion_Medicament",
                table: "Prescritpion_Medicament");

            migrationBuilder.RenameTable(
                name: "Prescritpion_Medicament",
                newName: "PrescritpionMedicaments");

            migrationBuilder.RenameIndex(
                name: "IX_Prescritpion_Medicament_IdMedicament",
                table: "PrescritpionMedicaments",
                newName: "IX_PrescritpionMedicaments_IdMedicament");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescritpionMedicaments",
                table: "PrescritpionMedicaments",
                columns: new[] { "IdPrescription", "IdMedicament" });

            migrationBuilder.AddForeignKey(
                name: "FK_PrescritpionMedicaments_Medicaments_IdMedicament",
                table: "PrescritpionMedicaments",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_IdPrescription",
                table: "PrescritpionMedicaments",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescripton",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
