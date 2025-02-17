using System.Collections;
using todoActions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Todo app!!!");

        ArrayList todoList = new ArrayList();

        while (true)
        {
            int completed = 0;
            int tasks = 0;

            Console.Write("Add, Remove, Complete, Edit, Show, Quit: ");
            var userInput = Console.ReadLine().ToLower();

            if (userInput.StartsWith("add"))
            {
                TodoActions.AddItem(todoList, userInput);
                TodoActions.ShowItems(todoList);
            }
            else if (userInput.StartsWith("remove"))
            {
                TodoActions.RemoveItem(todoList, userInput);
                TodoActions.ShowItems(todoList);
            }
            else if (userInput.StartsWith("complete"))
            {
                TodoActions.IsComplete(todoList, userInput);
                TodoActions.ShowItems(todoList);
            }
            else if (userInput.StartsWith("edit"))
            {
                TodoActions.EditItem(todoList, userInput);
                TodoActions.ShowItems(todoList);
            }
            else if (userInput == "show")
            {
                TodoActions.ShowItems(todoList);
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

            completed = TodoActions.TaskIsDone(todoList, completed);

            tasks = TodoActions.CountTasks(todoList, tasks);

            Console.WriteLine("Tasks completed: " + completed + "/" + tasks);
        }

    }
}

/*
TODO:

1. kada odem npr complete mlijeko, sruši se app jer sam napisao mijeko umjesto broja

 */