﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");

        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        // This will throw a NullReferenceException
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        manager.RemoveItem("Apple");

        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        // TODO: Implement this part three.
        ItemManager<Fruit> fruitManager = new ItemManager<Fruit>();
        fruitManager.AddItem(new Fruit("apple"));
        fruitManager.AddItem(new Fruit("pear"));
        fruitManager.AddItem(new Fruit("lemon"));
        fruitManager.PrintAllItems();

        // Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
        // TODO: Implement this part four.
    }
}

public interface IItemManager
{
    public void AddItem(string item);
    public void PrintAllItems();
    public void RemoveItem(string item);
    public void ClearAllItems();
}

public class Fruit(string fruitName)
{
    private string name = fruitName;

    public override string ToString()
    {
        return name;
    }
}

public class ItemManager  : IItemManager
{
    private List<string> items = [];

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Part Two: Implement the RemoveItem method
    // TODO: Implement this method
    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

public class ItemManager<T>
{
    private List<T> items = [];

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}