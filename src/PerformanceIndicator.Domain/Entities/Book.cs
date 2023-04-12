using PerformanceIndicator.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace PerformanceIndicator.Entities
{
    public class Book:AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BookType Type { get; set; }

    }
}
