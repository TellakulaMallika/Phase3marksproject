using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIstudentmarks.Models
{
    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? Marks { get; set; }
        public string? ClassName { get; set; }
    }
}
