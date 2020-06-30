using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsItemNew { get; set; } = true;
        public DateTime DateCreated { get; set; }

        public MenuItem(string itemName, double price, string description, string category, bool isItemNew)
        {
            ItemName = itemName;
            Price = price;
            Description = description;
            Category = category;
            IsItemNew = isItemNew;
            DateCreated = DateTime.Now;
        }

        public virtual void UpdateMenuItem()
        {
            // Item becomes old after a year
            DateTime now =  DateTime.Now;
            if ((now.Month - DateCreated.Month) % 12 > 1)
            {
                IsItemNew = false;          
            }
        }

     
    }
}
