using ConsoleApp.MiniToDoList.Controllers;
using ConsoleApp.MiniToDoList.Services;

namespace ConsoleApp.MiniToDoList;

public abstract class Program
{
    static void Main(string[] args)
    {
        // Create the repository (or inject it if using dependency injection)
        var repository = new InMemoryToDoRepository();

        // Create the service (optional)
        var toDoListService = new ToDoListService(repository);

        // Create the controller
        var controller = new ToDoListController(toDoListService);

        int choice;

        do
        {
            Console.WriteLine("To Do List:");
            Console.WriteLine("1. View All Tasks");
            Console.WriteLine("2. Add New Task");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllTasks(controller);
                    break;
                case 2:
                    AddTask(controller);
                    break;
                case 3:
                    MarkTaskComplete(controller);
                    break;
                case 4:
                    DeleteTask(controller);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);
    }

    private static void ShowAllTasks(ToDoListController controller)
    {
        var tasks = controller.GetTasks();
        if (tasks.Any())
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Id: {task.Id}, Description: {task.Description}, Completed: {task.IsCompleted}");
            }
        }
        else
        {
            Console.WriteLine("No tasks found!");
        }
    }

    private static void AddTask(ToDoListController controller)
    {
        Console.WriteLine("Enter task description: ");
        var description = Console.ReadLine();
        controller.AddTask(description);
        Console.WriteLine("Task added successfully!");
    }

    private static void MarkTaskComplete(ToDoListController controller)
    {
        Console.WriteLine("Enter task Id to mark complete: ");
        var id = Convert.ToInt32(Console.ReadLine());
        controller.MarkComplete(id);
        Console.WriteLine("Task marked complete!");
    }

    private static void DeleteTask(ToDoListController controller)
    {
        Console.WriteLine("Enter task Id to delete: ");
        var id = Convert.ToInt32(Console.ReadLine());
        controller.DeleteTask(id);
        Console.WriteLine("Task deleted!");
    }
}