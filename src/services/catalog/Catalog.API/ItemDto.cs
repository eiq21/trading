using System.ComponentModel.DataAnnotations;

namespace Catalog.API
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset createdDate);
    public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
}