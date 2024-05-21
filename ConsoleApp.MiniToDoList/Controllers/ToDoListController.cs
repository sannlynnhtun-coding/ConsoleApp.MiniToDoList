using ConsoleApp.MiniToDoList.Interfaces;
using ConsoleApp.MiniToDoList.Models;
using ConsoleApp.MiniToDoList.Services;

namespace ConsoleApp.MiniToDoList.Controllers;

public class ToDoListController
{
    private readonly ToDoListService _toDoListService;

    public ToDoListController(ToDoListService toDoListService)
    {
        _toDoListService = toDoListService;
    }

    public IEnumerable<ToDoItem> GetTasks()
    {
        return _toDoListService.GetTasks();
    }

    public void AddTask(string description)
    {
        _toDoListService.AddTask(description);
    }

    public void MarkComplete(int id)
    {
        _toDoListService.MarkComplete(id);
    }

    public void DeleteTask(int id)
    {
        _toDoListService.DeleteTask(id);
    }
}