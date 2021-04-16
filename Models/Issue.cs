using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public Severity Severity { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Submitted Date")]
        public DateTime SubmittedDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Resolved Date")]
        public DateTime ResolvedDate { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(512)]
        public string Notes { get; set; }

        [StringLength(512)]
        public string Resolution { get; set; }

        public bool Resolved { get; set; }

    }
}