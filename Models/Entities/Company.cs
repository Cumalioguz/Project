using System;
using System.Collections.Generic;

namespace Project.Models.Entities
{
    public partial class Company
    {
        public long CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyGsm { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyFax { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyCity { get; set; }
        public string? CompanyDistrict { get; set; }
        public string? CompanyAdress { get; set; }
        public string? CompanyVergiDairesi { get; set; }
        public string? CompanyVergiNo { get; set; }
        public string? CompanyFaturaAdresi { get; set; }
        public string? CompanyUsername { get; set; }
        public string? CompanyPassword { get; set; }
    }
}
