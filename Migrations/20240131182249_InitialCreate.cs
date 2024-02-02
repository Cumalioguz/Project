using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    company_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    company_gsm = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    company_phone = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_fax = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_district = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_adress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_vergi_dairesi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_vergi_no = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_fatura_adresi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_username = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    company_password = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.company_id);
                });

            migrationBuilder.CreateTable(
                name: "deneme",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    parent_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parent_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    parent_phone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    parent_username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    parent_userpassword = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.parent_id);
                });

            migrationBuilder.CreateTable(
                name: "school",
                columns: table => new
                {
                    school_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    school_code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    school_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_phone = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_faks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_gsm = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_district = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_adress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_web = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_ruhsat_aldigi_kurum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_yetkili = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_yekili_kimlik = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    school_yekili_ünvan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_username = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    school_password = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_school", x => x.school_id);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    student_idcart_no = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    student_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    student_surname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    student_gender = table.Column<bool>(type: "bit", nullable: true),
                    student_date_of_record = table.Column<DateTime>(type: "date", nullable: true),
                    student_ram_report_start_date = table.Column<DateTime>(type: "date", nullable: true),
                    student_ram_report_end_date = table.Column<DateTime>(type: "date", nullable: true),
                    student_hospital_report_start_date = table.Column<DateTime>(type: "date", nullable: true),
                    student_hospital_report_end_date = table.Column<DateTime>(type: "date", nullable: true),
                    student_ram_report_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    student_type_of_disabled = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    student_is_paid = table.Column<bool>(type: "bit", nullable: true),
                    student_blood_type = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    student_born_place = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    student_gsm_no = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    student_adress = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    student_city = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    student_district = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    student_neighborhood = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    student_school = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    student_is_active_student = table.Column<bool>(type: "bit", nullable: true),
                    student_which_class = table.Column<long>(type: "bigint", nullable: true),
                    student_still_student = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    student_date_of_birth = table.Column<DateTime>(type: "date", nullable: true),
                    student_ayrılma_tarihi = table.Column<DateTime>(type: "date", nullable: true),
                    student_mom_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    student_dad_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("student_pkey", x => x.student_idcart_no);
                });

            migrationBuilder.CreateTable(
                name: "teacher",
                columns: table => new
                {
                    teacher_idcart_no = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    teacher_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacher_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    teacher_surname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    teacher_title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    teacher_gender = table.Column<bool>(type: "bit", nullable: true),
                    teacher_mebbis_onay_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    teacher_date_of_record = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_date_of_leave_of_employment = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_gunluk_ders_sayısı = table.Column<long>(type: "bigint", nullable: true),
                    teacher_haftalik_ders_sayisi = table.Column<long>(type: "bigint", nullable: true),
                    teacher_aylik_ders_sayisi = table.Column<long>(type: "bigint", nullable: true),
                    teacher_blood_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_birth_of_date = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_birth_place = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_mom_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_dad_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_kodrolu_mu = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    teacher_gsm = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    teacher_sozlesme_baslangic = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_sozlesme_bitis = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_adress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    teacher_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teacher_password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("teacher_pkey", x => x.teacher_idcart_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "deneme");

            migrationBuilder.DropTable(
                name: "parents");

            migrationBuilder.DropTable(
                name: "school");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "teacher");
        }
    }
}
