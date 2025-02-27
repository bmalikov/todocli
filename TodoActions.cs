using System.Collections;
using inputOutput;

namespace todoActions;

public class TodoActions
{
    public static string toFile = "toFile.txt";

    public static void AddItem(List<string> TodoListInFile, string userInput)
    {

        if(userInput.Length < 4) 
        {
            Console.WriteLine("Please add new item after add...");
        }
        else 
        {
            var item = userInput[4..]; // [4..] uzima od 4 znaka nadalje
            TodoListInFile.Add(item);
        }
        WriteToFile.WriteTodoListItemToFile(TodoListInFile, toFile);
    }

    public static void RemoveItem(List<string> TodoListInFile, string userInput)
    {
        string itemToRemove = userInput[7..];

        int number; // ovo je potrebno zbog provjere isNumber

        bool isNumber = int.TryParse(itemToRemove, out number); // TryParse vraća true ili false, na ovaj način provjeravam jeli itemToRemove broj, ako nije ispisujem da treba napisati broj

        if(isNumber) {
            TodoListInFile.RemoveAt(int.Parse(itemToRemove) - 1);
        }
        else {
            Console.WriteLine("Enter index of item you want to remove!");
        }

        WriteToFile.WriteTodoListItemToFile(TodoListInFile, toFile);
    }

    public static void IsComplete(List<string> TodoListInFile, string userInput)
    {
        string itemIsComplete = userInput[8..];

        int number;

        bool isNumber = int.TryParse(itemIsComplete, out number);

        if(isNumber) {
            TodoListInFile[int.Parse(itemIsComplete) - 1] = TodoListInFile[int.Parse(itemIsComplete) - 1] + " --DONE";
        }
        else {
            Console.WriteLine("Enter index of item you want to complete!");
        }

        WriteToFile.WriteTodoListItemToFile(TodoListInFile, toFile);  
    }

    public static void EditItem(List<string> TodoListInFile, string userInput)
    {
        string itemToEdit = userInput[4..];
        int number;

        bool isNumber = int.TryParse(itemToEdit, out number);

        if(isNumber) {
            Console.Write("Enter new item: ");
            var editedItem = Console.ReadLine();
            TodoListInFile[int.Parse(itemToEdit) - 1] = editedItem;
        }
        else {
            Console.WriteLine("Enter index of item you want to edit!");
        }

        WriteToFile.WriteTodoListItemToFile(TodoListInFile, toFile); 
    }

    public static int TaskIsDone(List<string> TodoListInFile, int completed)
    {

        foreach (string item in TodoListInFile)
        {
            if (item.Contains("--DONE"))
            {
                completed = completed + 1;
            }
        }
        return completed;
    }

    public static void ShowItems(List<string> todoList)
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {todoList[i]}");
        }
    }

    public static int CountTasks(List<string> todoList, int tasks)
    {
        foreach (string item in todoList)
        {
            tasks = tasks + 1;
        }

        return tasks;
    }
}
