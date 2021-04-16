using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CRUD.Models
{
    public class Severity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Id { get; set; }
        
        [Required]
        [StringLength(16)]
        [Display(Name = "Severity Name")]
        public string SeverityName { get; set; }

    }
}