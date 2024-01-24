using System;
using Polygon.Ecom.Books;
using Polygon.Ecom.Dto.Books;
using Polygon.Ecom.Interface;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Polygon.Ecom.Services;

public class BookAppService :
    CrudAppService<
        Book,
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDto
    >,IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {

    }
}