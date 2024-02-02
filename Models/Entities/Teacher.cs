using System;
using System.Collections.Generic;

namespace Project.Models.Entities
{
    public partial class Teacher
    {
        public long TeacherId { get; set; }
        public string TeacherIdcartNo { get; set; } = null!;
        public string? TeacherName { get; set; }
        public string? TeacherSurname { get; set; }
        public string? TeacherTitle { get; set; }
        public bool? TeacherGender { get; set; }
        public string? TeacherMebbisOnayNo { get; set; }
        public DateTime? TeacherDateOfRecord { get; set; }
        public DateTime? TeacherDateOfLeaveOfEmployment { get; set; }
        public long? TeacherGunlukDersSayısı { get; set; }
        public long? TeacherHaftalikDersSayisi { get; set; }
        public long? TeacherAylikDersSayisi { get; set; }
        public string? TeacherBloodType { get; set; }
        public DateTime? TeacherBirthOfDate { get; set; }
        public string? TeacherBirthPlace { get; set; }
        public string? TeacherMomName { get; set; }
        public string? TeacherDadName { get; set; }
        public bool? TeacherKodroluMu { get; set; }
        public string? TeacherGsm { get; set; }
        public DateTime? TeacherSozlesmeBaslangic { get; set; }
        public DateTime? TeacherSozlesmeBitis { get; set; }
        public string? TeacherAdress { get; set; }
        public string? TeacherEmail { get; set; }
        public string? TeacherUsername { get; set; }
        public string? TeacherPassword { get; set; }
    }
}
