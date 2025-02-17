using System.Collections;

namespace todoActions;

public class TodoActions
{
    public static void AddItem(ArrayList todoList, string userInput)
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

    public static void RemoveItem(ArrayList todoList, string userInput)
    {
        var itemToRemove = int.Parse(userInput[7..]);
        todoList.RemoveAt(itemToRemove - 1);
    }

    public static void IsComplete(ArrayList todoList, string userInput)
    {
        var itemIsComplete = int.Parse(userInput[8..]);
        todoList[itemIsComplete - 1] = todoList[itemIsComplete - 1] + " --DONE";
    }

    public static void EditItem(ArrayList todoList, string userInput)
    {
        var itemToEdit = int.Parse(userInput[4..]);
        Console.Write("Enter new item: ");
        var editedItem = Console.ReadLine();
        todoList[itemToEdit - 1] = editedItem;
    }

    public static int TaskIsDone(ArrayList todoList, int completed)
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

    public static void ShowItems(ArrayList todoList)
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {todoList[i]}");
        }
    }

    public static int CountTasks(ArrayList todoList, int tasks)
    {
        foreach (string item in todoList)
        {
            tasks = tasks + 1;
        }

        return tasks;
    }

}
