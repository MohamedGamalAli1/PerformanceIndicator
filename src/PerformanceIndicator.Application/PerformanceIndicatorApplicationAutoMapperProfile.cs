using AutoMapper;
using PerformanceIndicator.Books.Dtos;
using PerformanceIndicator.Entities;

namespace PerformanceIndicator;

public class PerformanceIndicatorApplicationAutoMapperProfile : Profile
{
    public PerformanceIndicatorApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>().ForMember(d=>d.BookType,opt=>opt.MapFrom(s=>s.Type));
        CreateMap<CreateUpdateBookDto, Book>().ForMember(d=>d.Type,opt=>opt.MapFrom(s=>s.BookType));
    
    }
}
