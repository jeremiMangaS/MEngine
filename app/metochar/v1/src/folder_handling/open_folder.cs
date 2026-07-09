using System.IO;

namespace v1.src.folder_handling
{
    public class Folder_Handling
    {
        public static string[] folder_handling_func(string user_input)
        {
            string[] items = Directory.GetFiles(user_input, "*", SearchOption.AllDirectories);
            return items;
        }
    }
}