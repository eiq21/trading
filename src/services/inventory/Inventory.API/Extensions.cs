using Inventory.API.Entities;

namespace Inventory.API
{
    public static class Extensions
    {
        public static InventoryItemDto asDto(this InventoryItem item)
        {
            return new InventoryItemDto(item.CatalogItemId, item.Quantity, item.AcquiredDate);
        }
    }
}