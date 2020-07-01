using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated { get; set; }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
            LastUpdated = DateTime.Now;
        }

        public void DeleteItem(MenuItem item)
        {
            Items.Remove(item);
            LastUpdated = DateTime.Now;
        }


        public string ItemStatus(MenuItem item)
        {
            item.UpdateMenuItem();
            if (item.IsItemNew)
            {
                return item.ItemName + "is new.";
            }
            else
            {
                return item.ItemName + "is not new.";
            }
            
        }

        public string DateUpdated()
        {
            return "Last updated: " + LastUpdated;
        }

        public List<string> GetMenuItems()
        {
            List<string> items = new List<string>();
            foreach (MenuItem item in Items)
            {
                items.Add("Name: " + item.ItemName + " ----- Description: " + item.Description + "----- Category: " + item.Category + "----- Price: " + item.Price);
            }
            return items;
        }

        public void PrintMenuItems()
        {
            List<string> items = GetMenuItems();
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public string AreItemsEqual(MenuItem item1, MenuItem item2)
        {
            if (item1.ItemName == item2.ItemName && item1.Category == item2.Category)
            {
                return item1.ItemName + " and " + item2.ItemName + " are the same items.";
            }
            return item1.ItemName + " and " + item2.ItemName + " are different items.";
        }

    }
}
