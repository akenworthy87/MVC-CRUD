using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.model
{
    public class Severity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Severity { get; set; }

    }
}