using System;
using System.Collections.Generic;

namespace Project.Models.Entities
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string StudentIdcartNo { get; set; } = null!;
        public bool? StudentGender { get; set; }
        public DateTime? StudentDateOfRecord { get; set; }
        public DateTime? StudentRamReportStartDate { get; set; }
        public DateTime? StudentRamReportEndDate { get; set; }
        public DateTime? StudentHospitalReportStartDate { get; set; }
        public DateTime? StudentHospitalReportEndDate { get; set; }
        public string? StudentRamReportNo { get; set; }
        public string? StudentTypeOfDisabled { get; set; }
        public bool? StudentIsPaid { get; set; }
        public string? StudentBloodType { get; set; }
        public string? StudentBornPlace { get; set; }
        public string? StudentGsmNo { get; set; }
        public string? StudentAdress { get; set; }
        public string? StudentCity { get; set; }
        public string? StudentDistrict { get; set; }
        public string? StudentNeighborhood { get; set; }
        public string? StudentSchool { get; set; }
        public bool? StudentIsActiveStudent { get; set; }
        public long? StudentWhichClass { get; set; }
        public bool? StudentStillStudent { get; set; }
        public DateTime? StudentDateOfBirth { get; set; }
        public DateTime? StudentAyrılmaTarihi { get; set; }
        public string? StudentMomName { get; set; }
        public string? StudentDadName { get; set; }
    }
}
