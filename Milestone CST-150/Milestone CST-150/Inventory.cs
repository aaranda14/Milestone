using System.Collections.Generic;

public class Inventory
{
    private List<string> items;

    public Inventory()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

    public List<string> GetAllItems()
    {
        return items;
    }
}
