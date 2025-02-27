using System.Collections;

namespace inputOutput;

public class WriteToFile
{
    public static void WriteTodoListItemToFile(List<string> todoList, string toFile)
    {
        using(StreamWriter todoListToFile = new StreamWriter(toFile)) {
            foreach (var item in todoList)
            {
                todoListToFile.Write(item + "\n"); 

            }
        }
    }
}
