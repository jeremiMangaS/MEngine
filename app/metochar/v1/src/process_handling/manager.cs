using System;
using System.IO;
using v1.src.folder_handling;
using v1.src.file_handling;
using System.Threading.Tasks;

namespace v1.src.process_handling
{
    public class Manager_Class
    {
        private static string[] _items;
        public static string[] Items
        {
            get { return _items; }
        }

        public async Task Process_Manager(string user_input)
        {
            try
            {
                _items = Folder_Handling.folder_handling_func(user_input);

                // _Items_Check(); // Testing : Memastikan sistem dapat membaca isi folder

                await File_Manager.File_List_Managing(_items);
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

        private void _Items_Check()
        {
            foreach (string _files in _items)
            {
                Console.WriteLine(_files);
            }
        }
    }
}