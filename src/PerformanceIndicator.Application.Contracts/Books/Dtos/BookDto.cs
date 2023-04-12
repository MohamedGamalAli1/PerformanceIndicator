using PerformanceIndicator.Books;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PerformanceIndicator.Books.Dtos
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public BookType BookType { get; set; }
    }
}
