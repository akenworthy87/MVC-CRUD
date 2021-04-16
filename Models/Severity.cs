using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Severity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Severity Name")]
        public string SeverityName { get; set; }

    }
}