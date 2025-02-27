using System.Collections;
using todoActions;
using inputOutput;
using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to Todo app!!!");

List<string> TodoListInFile =  new List<string>();

foreach (var item in File.ReadAllLines("toFile.txt"))
{
    TodoListInFile.Add(item);
}

TodoActions.ShowItems(TodoListInFile);

while (true)
{
    int completed = 0;
    int tasks = 0;


    Console.Write("Add, Remove, Complete, Edit, Show, Quit: ");
    string userInput = Console.ReadLine().ToLower();


    if (userInput.StartsWith("add"))
    {
        TodoActions.AddItem(TodoListInFile, userInput);
        TodoActions.ShowItems(TodoListInFile);
    }
    else if (userInput.StartsWith("remove"))
    {
        TodoActions.RemoveItem(TodoListInFile, userInput);
        TodoActions.ShowItems(TodoListInFile);
    }
    else if (userInput.StartsWith("complete"))
    {
        TodoActions.IsComplete(TodoListInFile, userInput);
        TodoActions.ShowItems(TodoListInFile);
    }
    else if (userInput.StartsWith("edit"))
    {
        TodoActions.EditItem(TodoListInFile, userInput);
        TodoActions.ShowItems(TodoListInFile);
    }
    else if (userInput == "show")
    {
        //TodoActions.ShowItems(todoList);
        foreach (var item in TodoListInFile)
        {
            Console.WriteLine(item);
        }

    }
    else if (userInput == "quit")
    {
        Console.WriteLine("Byeeee!!!");
        break;
    }
    else
    {
        Console.WriteLine("Unknown command!!!");
    }

    completed = TodoActions.TaskIsDone(TodoListInFile, completed);

    tasks = TodoActions.CountTasks(TodoListInFile, tasks);

    Console.WriteLine("Tasks completed: " + completed + "/" + tasks);
}
