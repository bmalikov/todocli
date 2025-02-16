using System.Collections;

class Program
{
    static void AddItem(ArrayList todoList, string userInput)
    {
        if(userInput.Length < 4) 
        {
            Console.WriteLine("Please add new item after add...");
        }
        else 
        {
            var item = userInput[4..]; // [4..] uzima od 4 znaka nadalje
            todoList.Add(item);
        }
    }

    static void RemoveItem(ArrayList todoList, string userInput)
    {
        var itemToRemove = int.Parse(userInput[7..]);
        todoList.RemoveAt(itemToRemove - 1);
    }

    static void IsComplete(ArrayList todoList, string userInput)
    {
        var itemIsComplete = int.Parse(userInput[8..]);
        todoList[itemIsComplete - 1] = todoList[itemIsComplete - 1] + " --DONE";
    }

    static void EditItem(ArrayList todoList, string userInput)
    {
        var itemToEdit = int.Parse(userInput[4..]);
        Console.Write("Enter new item: ");
        var editedItem = Console.ReadLine();
        todoList[itemToEdit - 1] = editedItem;
    }

    static int TaskIsDone(ArrayList todoList, int completed)
    {

        foreach (string item in todoList)
        {
            if (item.Contains("--DONE"))
            {
                completed = completed + 1;
            }
        }
        return completed;
    }

    static int CountTasks(ArrayList todoList, int tasks)
    {
        foreach (string item in todoList)
        {
            tasks = tasks + 1;
        }

        return tasks;
    }
    static void ShowItems(ArrayList todoList)
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {todoList[i]}");
        }
    }

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
                AddItem(todoList, userInput);
                ShowItems(todoList);
            }
            else if (userInput.StartsWith("remove"))
            {
                RemoveItem(todoList, userInput);
                ShowItems(todoList);
            }
            else if (userInput.StartsWith("complete"))
            {
                IsComplete(todoList, userInput);
                ShowItems(todoList);
            }
            else if (userInput.StartsWith("edit"))
            {
                EditItem(todoList, userInput);
                ShowItems(todoList);
            }
            else if (userInput == "show")
            {
                ShowItems(todoList);
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

            completed = TaskIsDone(todoList, completed);

            tasks = CountTasks(todoList, tasks);

            Console.WriteLine("Tasks completed: " + completed + "/" + tasks);
        }

    }
}

/*
TODO:

1. kada odem npr complete mlijeko, sruši se app jer sam napisao mijeko umjesto broja

 */