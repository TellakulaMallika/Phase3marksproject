using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIstudentmarks.Models
{
    [Table("Class")]
    public partial class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
