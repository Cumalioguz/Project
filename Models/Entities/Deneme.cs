using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models.Entities
{
    public partial class Deneme
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public string? value { get; set; }
    }
}
