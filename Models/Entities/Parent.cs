using System;
using System.Collections.Generic;

namespace Project.Models.Entities
{
    public partial class Parent
    {
        public long ParentId { get; set; }
        public string? ParentName { get; set; }
        public string? ParentPhone { get; set; }
        public string? ParentUsername { get; set; }
        public string? ParentUserpassword { get; set; }
    }
}
