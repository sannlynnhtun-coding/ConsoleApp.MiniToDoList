using ConsoleApp.MiniToDoList.Interfaces;
using ConsoleApp.MiniToDoList.Models;

namespace ConsoleApp.MiniToDoList.Services;

public class InMemoryToDoRepository : IToDoRepository
{
    private readonly List<ToDoItem> _items;

    public InMemoryToDoRepository()
    {
        _items = new List<ToDoItem>();
    }

    public IEnumerable<ToDoItem> GetAll()
    {
        return _items.ToList();
    }

    public ToDoItem GetById(int id)
    {
        return _items.FirstOrDefault(x => x.Id == id);
    }

    public void Add(ToDoItem item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public void Update(ToDoItem item)
    {
        var existingItem = GetById(item.Id);
        if (existingItem != null)
        {
            existingItem.Description = item.Description;
            existingItem.IsCompleted = item.IsCompleted;
        }
    }

    public void Delete(int id)
    {
        var itemToDelete = GetById(id);
        if (itemToDelete != null)
        {
            _items.Remove(itemToDelete);
        }
    }
}