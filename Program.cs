using System.Collections;

Console.WriteLine("Welcome to Todo app!!!");

ArrayList todoList = new ArrayList(); 

while(true) {

    Console.Write("Add, Remove, Complete, Edit, Show, Quit: ");
    var userInput = Console.ReadLine().ToLower();

    if (userInput == "Add") {
        Console.Write("Enter new item: ");
        var item = Console.ReadLine();
        todoList.Add(item);
    }
    else if(userInput == "Remove") {
        Console.Write("Enter index of item to remove: ");
        var itemToRemove = int.Parse(Console.ReadLine());
        todoList.RemoveAt(itemToRemove - 1);
    }
    else if(userInput == "Complete") {
        Console.Write("Enter index of completed item: ");
        var itemIsComplete = int.Parse(Console.ReadLine());
        todoList[itemIsComplete - 1] = todoList[itemIsComplete - 1] + " --DONE";
    }
    else if(userInput == "Edit") {
        Console.Write("Enter index of item to edit: ");
        var itemToEdit = int.Parse(Console.ReadLine());
        Console.Write("Enter new item: ");
        var editedItem = Console.ReadLine();
        todoList[itemToEdit - 1] = editedItem;
    }
    else if(userInput == "Show") {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {todoList[i]}");
        }
    }
    else if(userInput == "Quit") {
        Console.WriteLine("Byeeee!!!");
        break;
    }
    else {
        Console.WriteLine("Unknown command!!!");
    }
}