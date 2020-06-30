using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated { get; set; }

        public virtual void AddItem(MenuItem item)
        {
            Items.Add(item);
            LastUpdated = DateTime.Now;
        }

        public virtual void DeleteItem(MenuItem item)
        {
            Items.Remove(item);
            LastUpdated = DateTime.Now;
        }
    }
}
