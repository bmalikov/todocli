using System.Collections;

class Program
{
    static void AddItem(ArrayList todoList)
    {
        Console.Write("Enter new item: ");
        var item = Console.ReadLine();
        todoList.Add(item);
    }

    static void RemoveItem(ArrayList todoList)
    {
        Console.Write("Enter index of item to remove: ");
        var itemToRemove = int.Parse(Console.ReadLine());
        todoList.RemoveAt(itemToRemove - 1);
    }

    static void IsComplete(ArrayList todoList)
    {
        Console.Write("Enter index of completed item: ");
        var itemIsComplete = int.Parse(Console.ReadLine());
        todoList[itemIsComplete - 1] = todoList[itemIsComplete - 1] + " --DONE";
    }

    static void EditItem(ArrayList todoList)
    {
        Console.Write("Enter index of item to edit: ");
        var itemToEdit = int.Parse(Console.ReadLine());
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

            if (userInput == "add")
            {
                AddItem(todoList);
            }
            else if (userInput == "remove")
            {
                RemoveItem(todoList);
            }
            else if (userInput == "complete")
            {
                IsComplete(todoList);
            }
            else if (userInput == "edit")
            {
                EditItem(todoList);
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