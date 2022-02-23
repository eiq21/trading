using Inventory.API.Entities;

namespace Inventory.API
{
    public static class Extensions
    {
        public static InventoryItemDto asDto(this InventoryItem item, string Name, string Description)
        {
            return new InventoryItemDto(item.CatalogItemId, Name, Description, item.Quantity, item.AcquiredDate);
        }
    }
}