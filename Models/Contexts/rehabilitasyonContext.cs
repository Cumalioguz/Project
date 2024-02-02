using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Project.Models.Entities;

namespace Project.Models.Contexts
{
    public partial class rehabilitasyonContext : DbContext
    {
        public rehabilitasyonContext()
        {
        }

        public rehabilitasyonContext(DbContextOptions<rehabilitasyonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Deneme> Denemes { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\project;Database=rehabilitasyon;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanyAdress)
                    .IsUnicode(false)
                    .HasColumnName("company_adress");

                entity.Property(e => e.CompanyCity)
                    .IsUnicode(false)
                    .HasColumnName("company_city");

                entity.Property(e => e.CompanyDistrict)
                    .IsUnicode(false)
                    .HasColumnName("company_district");

                entity.Property(e => e.CompanyEmail)
                    .IsUnicode(false)
                    .HasColumnName("company_email");

                entity.Property(e => e.CompanyFaturaAdresi)
                    .IsUnicode(false)
                    .HasColumnName("company_fatura_adresi");

                entity.Property(e => e.CompanyFax)
                    .IsUnicode(false)
                    .HasColumnName("company_fax");

                entity.Property(e => e.CompanyGsm)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("company_gsm");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyPassword)
                    .IsUnicode(false)
                    .HasColumnName("company_password");

                entity.Property(e => e.CompanyPhone)
                    .IsUnicode(false)
                    .HasColumnName("company_phone");

                entity.Property(e => e.CompanyUsername)
                    .IsUnicode(false)
                    .HasColumnName("company_username");

                entity.Property(e => e.CompanyVergiDairesi)
                    .IsUnicode(false)
                    .HasColumnName("company_vergi_dairesi");

                entity.Property(e => e.CompanyVergiNo)
                    .IsUnicode(false)
                    .HasColumnName("company_vergi_no");
            });

            modelBuilder.Entity<Deneme>(entity =>
            {
                //entity.HasNoKey();

                entity.HasKey(e => e.Id);
                entity.ToTable("deneme");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.value)
                    .HasMaxLength(50)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parents");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("parent_name");

                entity.Property(e => e.ParentPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("parent_phone");

                entity.Property(e => e.ParentUsername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("parent_username");

                entity.Property(e => e.ParentUserpassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("parent_userpassword");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("school");

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.SchoolAdress)
                    .IsUnicode(false)
                    .HasColumnName("school_adress");

                entity.Property(e => e.SchoolCity)
                    .IsUnicode(false)
                    .HasColumnName("school_city");

                entity.Property(e => e.SchoolCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("school_code");

                entity.Property(e => e.SchoolDistrict)
                    .IsUnicode(false)
                    .HasColumnName("school_district");

                entity.Property(e => e.SchoolEmail)
                    .IsUnicode(false)
                    .HasColumnName("school_email");

                entity.Property(e => e.SchoolFaks)
                    .IsUnicode(false)
                    .HasColumnName("school_faks");

                entity.Property(e => e.SchoolGsm)
                    .IsUnicode(false)
                    .HasColumnName("school_gsm");

                entity.Property(e => e.SchoolName)
                    .IsUnicode(false)
                    .HasColumnName("school_name");

                entity.Property(e => e.SchoolPassword)
                    .IsUnicode(false)
                    .HasColumnName("school_password");

                entity.Property(e => e.SchoolPhone)
                    .IsUnicode(false)
                    .HasColumnName("school_phone");

                entity.Property(e => e.SchoolRuhsatAldigiKurum)
                    .IsUnicode(false)
                    .HasColumnName("school_ruhsat_aldigi_kurum");

                entity.Property(e => e.SchoolUsername)
                    .IsUnicode(false)
                    .HasColumnName("school_username");

                entity.Property(e => e.SchoolWeb)
                    .IsUnicode(false)
                    .HasColumnName("school_web");

                entity.Property(e => e.SchoolYekiliKimlik)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("school_yekili_kimlik");

                entity.Property(e => e.SchoolYekiliÜnvan)
                    .IsUnicode(false)
                    .HasColumnName("school_yekili_ünvan");

                entity.Property(e => e.SchoolYetkili)
                    .IsUnicode(false)
                    .HasColumnName("school_yetkili");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentIdcartNo)
                    .HasName("student_pkey");

                entity.ToTable("student");

                entity.Property(e => e.StudentIdcartNo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("student_idcart_no");

                entity.Property(e => e.StudentAdress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("student_adress");

                entity.Property(e => e.StudentAyrılmaTarihi)
                    .HasColumnType("date")
                    .HasColumnName("student_ayrılma_tarihi");

                entity.Property(e => e.StudentBloodType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("student_blood_type");

                entity.Property(e => e.StudentBornPlace)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("student_born_place");

                entity.Property(e => e.StudentCity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("student_city");

                entity.Property(e => e.StudentDadName)
                    .IsUnicode(false)
                    .HasColumnName("student_dad_name");

                entity.Property(e => e.StudentDateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("student_date_of_birth");

                entity.Property(e => e.StudentDateOfRecord)
                    .HasColumnType("date")
                    .HasColumnName("student_date_of_record");

                entity.Property(e => e.StudentDistrict)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("student_district");

                entity.Property(e => e.StudentGender).HasColumnName("student_gender");

                entity.Property(e => e.StudentGsmNo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("student_gsm_no");

                entity.Property(e => e.StudentHospitalReportEndDate)
                    .HasColumnType("date")
                    .HasColumnName("student_hospital_report_end_date");

                entity.Property(e => e.StudentHospitalReportStartDate)
                    .HasColumnType("date")
                    .HasColumnName("student_hospital_report_start_date");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("student_id");

                entity.Property(e => e.StudentIsActiveStudent).HasColumnName("student_is_active_student");

                entity.Property(e => e.StudentIsPaid).HasColumnName("student_is_paid");

                entity.Property(e => e.StudentMomName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_mom_name");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_name");

                entity.Property(e => e.StudentNeighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("student_neighborhood");

                entity.Property(e => e.StudentRamReportEndDate)
                    .HasColumnType("date")
                    .HasColumnName("student_ram_report_end_date");

                entity.Property(e => e.StudentRamReportNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("student_ram_report_no");

                entity.Property(e => e.StudentRamReportStartDate)
                    .HasColumnType("date")
                    .HasColumnName("student_ram_report_start_date");

                entity.Property(e => e.StudentSchool)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("student_school");

                entity.Property(e => e.StudentStillStudent)
                    .HasColumnName("student_still_student")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StudentSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_surname");

                entity.Property(e => e.StudentTypeOfDisabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_type_of_disabled");

                entity.Property(e => e.StudentWhichClass).HasColumnName("student_which_class");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeacherIdcartNo)
                    .HasName("teacher_pkey");

                entity.ToTable("teacher");

                entity.Property(e => e.TeacherIdcartNo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("teacher_idcart_no");

                entity.Property(e => e.TeacherAdress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("teacher_adress");

                entity.Property(e => e.TeacherAylikDersSayisi).HasColumnName("teacher_aylik_ders_sayisi");

                entity.Property(e => e.TeacherBirthOfDate)
                    .HasColumnType("date")
                    .HasColumnName("teacher_birth_of_date");

                entity.Property(e => e.TeacherBirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_birth_place");

                entity.Property(e => e.TeacherBloodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_blood_type");

                entity.Property(e => e.TeacherDadName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_dad_name");

                entity.Property(e => e.TeacherDateOfLeaveOfEmployment)
                    .HasColumnType("date")
                    .HasColumnName("teacher_date_of_leave_of_employment");

                entity.Property(e => e.TeacherDateOfRecord)
                    .HasColumnType("date")
                    .HasColumnName("teacher_date_of_record");

                entity.Property(e => e.TeacherEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_email");

                entity.Property(e => e.TeacherGender).HasColumnName("teacher_gender");

                entity.Property(e => e.TeacherGsm)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("teacher_gsm");

                entity.Property(e => e.TeacherGunlukDersSayısı).HasColumnName("teacher_gunluk_ders_sayısı");

                entity.Property(e => e.TeacherHaftalikDersSayisi).HasColumnName("teacher_haftalik_ders_sayisi");

                entity.Property(e => e.TeacherId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("teacher_id");

                entity.Property(e => e.TeacherKodroluMu)
                    .HasColumnName("teacher_kodrolu_mu")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TeacherMebbisOnayNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("teacher_mebbis_onay_no");

                entity.Property(e => e.TeacherMomName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_mom_name");

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("teacher_name");

                entity.Property(e => e.TeacherPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_password");

                entity.Property(e => e.TeacherSozlesmeBaslangic)
                    .HasColumnType("date")
                    .HasColumnName("teacher_sozlesme_baslangic");

                entity.Property(e => e.TeacherSozlesmeBitis)
                    .HasColumnType("date")
                    .HasColumnName("teacher_sozlesme_bitis");

                entity.Property(e => e.TeacherSurname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("teacher_surname");

                entity.Property(e => e.TeacherTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("teacher_title");

                entity.Property(e => e.TeacherUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teacher_username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
