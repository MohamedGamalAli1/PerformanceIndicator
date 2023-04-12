using PerformanceIndicator.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PerformanceIndicator.Books.Dtos
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public BookType BookType { get; set; }
    }
}
