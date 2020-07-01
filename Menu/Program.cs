using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem item = new MenuItem("a", 5, "abc", "dessert", true);
            MenuItem item1 = new MenuItem("b", 5, "def", "dessert", true);
            MenuItem item2 = new MenuItem("c", 5, "ghi", "main", true);
            Menu menu = new Menu();

            menu.AddItem(item);
            menu.AddItem(item1);
            menu.AddItem(item2);

            //menu.DeleteItem(item);
            Console.WriteLine(menu.Items[0].DateCreated.ToString("MM-dd-yyyy"));
            Console.WriteLine(item1.IsItemNew);
            item1.UpdateMenuItem();
            Console.WriteLine(item1.IsItemNew);

            Console.WriteLine(menu.ItemStatus(item1));

            Console.WriteLine(menu.DateUpdated());

            Console.WriteLine(menu.GetMenuItems()[0]);

            menu.PrintMenuItems();

            Console.WriteLine(menu.AreItemsEqual(item, item1));
        }
    }
}
