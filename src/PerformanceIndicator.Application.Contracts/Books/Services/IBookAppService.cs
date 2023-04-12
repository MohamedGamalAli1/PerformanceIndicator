using PerformanceIndicator.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PerformanceIndicator.Books.Services
{
    public interface IBookAppService:ICrudAppService<BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>
    {
    }
}
