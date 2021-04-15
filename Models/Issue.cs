using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.model
{
    public class Movie
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
        public DateTime SubmittedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ResolvedDate { get; set; }

        [Required]
        [StringLength(512)]
        public string Issue { get; set; }

        [StringLength(512)]
        public string Notes { get; set; }

        [StringLength(512)]
        public string Resolution { get; set; }

    }
}