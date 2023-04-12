using PerformanceIndicator.Books.Services;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace PerformanceIndicator.Books.BookAppService_Tests
{
    //public class BookAppService_Tests: BookStoreApplication
    public class BookAppService_Tests: PerformanceIndicatorApplicationTestBase
    {
        private readonly IBookAppService _bookAppService;

        public BookAppService_Tests(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        [Fact]  
        public async Task Should_Get_list_of_Books()
        {
            //Act
            var result = await _bookAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Asset
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Name == "aa");

        }
    }
}
