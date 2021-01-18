using ShoppingCarts.Helpers;
using ShoppingCarts.Model;
using ShoppingCarts.Services.ServiceInterface;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShoppingCarts.Services.ServiceImplementation.ItemService))]

namespace ShoppingCarts.Services.ServiceImplementation
{
    public class ItemService : IItemService
    {
        private List<Item> Items;

        public ItemService()
        {
            Items = new List<Item>();
        }

        public async Task<List<Item>> GetItems()
        {
            Items.Clear();

            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Koran",
                Index = 1,
                Status = Settings.ItemStatus1,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Majalah",
                Index = 2,
                Status = Settings.ItemStatus2,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Botol Kaca",
                Index = 3,
                Status = Settings.ItemStatus3,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Aqua",
                Index = 4,
                Status = Settings.ItemStatus4,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Mika",
                Index = 5,
                Status = Settings.ItemStatus5,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Plastik",
                Index = 6,
                Status = Settings.ItemStatus6,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "kertas",
                Index = 7,
                Status = Settings.ItemStatus7,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "kain",
                Index = 8,
                Status = Settings.ItemStatus8,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
            Items.Add(new Item
            {
                Image = "https://www.sendspace.com/file/k6yy25",
                Name = "Botol",
                Index = 9,
                Status = Settings.ItemStatus9,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            return await Task.FromResult(Items);
        }
    }
}