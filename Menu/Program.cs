using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem item = new MenuItem("a", 5, "abc", "dessert", true);
            MenuItem item1 = new MenuItem("b", 5, "def", "dessert", true);
            Menu menu = new Menu();

            menu.AddItem(item);
            menu.AddItem(item1);

            menu.DeleteItem(item);
            Console.WriteLine(menu.Items[0].DateCreated.ToString("MM-dd-yyyy"));
            Console.WriteLine(item1.IsItemNew);
            item1.UpdateMenuItem();
            Console.WriteLine(item1.IsItemNew);
        }
    }
}
