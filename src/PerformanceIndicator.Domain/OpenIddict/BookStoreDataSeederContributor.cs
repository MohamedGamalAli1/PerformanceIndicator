using PerformanceIndicator.Books;
using PerformanceIndicator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace PerformanceIndicator.OpenIddict
{
    internal class BookStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _repository;

        public BookStoreDataSeederContributor(IRepository<Book, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            var hasData =await _repository.CountAsync() <= 0;
            if (hasData)
            {
               await _repository.InsertAsync(new Book()
                {
                    Name = "1984",
                    Type = BookType.Fantastic
                },autoSave:true);
                await _repository.InsertAsync(new Book()
                {
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Type = BookType.Dystopia
                }, autoSave: true);
            }
        }
    }
}
