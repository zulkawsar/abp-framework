using System;
using Polygon.Ecom.Dto.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Polygon.Ecom.Interface;

public interface IBookAppService :
    ICrudAppService<
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDto>
{
    
}