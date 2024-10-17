using System;

public class Class1
{
	public Class1()
	{

        public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

public class ShoppingCart
{
    private List<Item> items;

    public ShoppingCart()
    {
        items = new List<Item>();
    }

    // Add an item to the cart
    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} added to the cart.");
    }

    // Remove an item from the cart
    public void RemoveItem(string itemName)
    {
        var itemToRemove = items.FirstOrDefault(i => i.Name == itemName);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine($"{itemName} removed from the cart.");
        }
        else
        {
            Console.WriteLine($"{itemName} not found in the cart.");
        }
    }

    // View the total price of the items in the cart
    public decimal GetTotalPrice()
    {
        return items.Sum(i => i.Price);
    }

    // Display the items in the cart
    public void DisplayCart()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Your cart is empty.");
            return;
        }

        Console.WriteLine("Items in your cart:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name}: ${item.Price}");
        }
    }
}

class Program
{
     public static void cart()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddItem(new Item("Laptop", 999.99m));
        cart.AddItem(new Item("Headphones", 199.99m));
        cart.AddItem(new Item("Mouse", 49.99m));

        cart.DisplayCart();
        Console.WriteLine($"Total Price: ${cart.GetTotalPrice()}");

        cart.RemoveItem("Headphones");
        cart.DisplayCart();
        Console.WriteLine($"Total Price: ${cart.GetTotalPrice()}");
    }
}
	}
}
