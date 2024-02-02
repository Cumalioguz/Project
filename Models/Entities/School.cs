using System;
using System.Collections.Generic;

namespace Project.Models.Entities
{
    public partial class School
    {
        public long SchoolId { get; set; }
        public string? SchoolCode { get; set; }
        public string? SchoolName { get; set; }
        public string? SchoolPhone { get; set; }
        public string? SchoolFaks { get; set; }
        public string? SchoolGsm { get; set; }
        public string? SchoolCity { get; set; }
        public string? SchoolDistrict { get; set; }
        public string? SchoolAdress { get; set; }
        public string? SchoolWeb { get; set; }
        public string? SchoolEmail { get; set; }
        public string? SchoolRuhsatAldigiKurum { get; set; }
        public string? SchoolYetkili { get; set; }
        public string? SchoolYekiliKimlik { get; set; }
        public string? SchoolYekiliÜnvan { get; set; }
        public string? SchoolUsername { get; set; }
        public string? SchoolPassword { get; set; }
    }
}
