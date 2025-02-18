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
        string itemToRemove = userInput[7..];

        int number; // ovo je potrebno zbog provjere isNumber

        bool isNumber = int.TryParse(itemToRemove, out number); // TryParse vraća true ili false, na ovaj način provjeravam jeli itemToRemove broj, ako nije ispisujem da treba napisati broj

        if(isNumber) {
            todoList.RemoveAt(int.Parse(itemToRemove) - 1);
        }
        else {
            Console.WriteLine("Enter index of item you want to remove!");
        }
    }

    public static void IsComplete(ArrayList todoList, string userInput)
    {
        string itemIsComplete = userInput[8..];

        int number;

        bool isNumber = int.TryParse(itemIsComplete, out number);

        if(isNumber) {
            todoList[int.Parse(itemIsComplete) - 1] = todoList[int.Parse(itemIsComplete) - 1] + " --DONE";
        }
        else {
            Console.WriteLine("Enter index of item you want to complete!");
        }  
    }

    public static void EditItem(ArrayList todoList, string userInput)
    {
        string itemToEdit = userInput[4..];
        int number;

        bool isNumber = int.TryParse(itemToEdit, out number);

        if(isNumber) {
            Console.Write("Enter new item: ");
            var editedItem = Console.ReadLine();
            todoList[int.Parse(itemToEdit) - 1] = editedItem;
        }
        else {
            Console.WriteLine("Enter index of item you want to edit!");
        }
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
