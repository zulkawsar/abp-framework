using System;
using Polygon.Ecom.Books;
using Volo.Abp.Application.Dtos;

namespace Polygon.Ecom.Dto.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string? Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}