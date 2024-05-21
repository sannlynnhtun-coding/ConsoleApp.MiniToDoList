using ConsoleApp.MiniToDoList.Interfaces;
using ConsoleApp.MiniToDoList.Models;

namespace ConsoleApp.MiniToDoList.Services;

public class ToDoListService
{
    private readonly IToDoRepository _repository;

    public ToDoListService(IToDoRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<ToDoItem> GetTasks()
    {
        return _repository.GetAll();
    }

    public void AddTask(string description)
    {
        _repository.Add(new ToDoItem { Description = description });
    }

    public void MarkComplete(int id)
    {
        _repository.Update(new ToDoItem { Id = id, IsCompleted = true });
    }

    public void DeleteTask(int id)
    {
        _repository.Delete(id);
    }
}