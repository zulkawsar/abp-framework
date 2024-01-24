using AutoMapper;
using Polygon.Ecom.Books;
using Polygon.Ecom.Dto.Books;

namespace Polygon.Ecom;

public class EcomApplicationAutoMapperProfile : Profile
{
    public EcomApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
