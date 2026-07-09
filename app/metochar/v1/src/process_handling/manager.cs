using System;
using System.IO;
using v1.src.folder_handling;

namespace v1.src.process_handling
{
    public class Manager_Class
    {
        private static string[] _items;
        public static string[] Items
        {
            get { return _items; }
        }

        public void Process_Manager(string user_input)
        {
            try
            {
                _items = Folder_Handling.folder_handling_func(user_input);
                Items_Check();
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.Error.WriteLine($"Error : Folder tidak ditemukan\nDetail : {ex.Message}");
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine($"Error : {ex.Message}");
                return;
            }
        }

        public void Items_Check()
        {
            foreach (string _files in _items)
            {
                Console.WriteLine(_files);
            }
        }
    }
}