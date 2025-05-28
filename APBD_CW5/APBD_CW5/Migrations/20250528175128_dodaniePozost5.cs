using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_CW5.Migrations
{
    /// <inheritdoc />
    public partial class dodaniePozost5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctor_IdDoctor",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropIndex(
                name: "IX_PrescritpionMedicaments_PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropColumn(
                name: "IdPrescripton",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "IdDoctor");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_IdPrescription",
                table: "PrescritpionMedicaments",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescripton",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_IdDoctor",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_IdPrescription",
                table: "PrescritpionMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPrescripton",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_PrescritpionMedicaments_PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments",
                column: "PrescriptionIdPrescripton");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctor_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor",
                principalTable: "Doctor",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescritpionMedicaments_Prescriptions_PrescriptionIdPrescripton",
                table: "PrescritpionMedicaments",
                column: "PrescriptionIdPrescripton",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescripton");
        }
    }
}
