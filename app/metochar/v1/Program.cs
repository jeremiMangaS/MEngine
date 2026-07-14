using System;
using System.Threading.Tasks;
using v1.src.process_handling;

namespace v1
{
    public class Main_App
    {
        public static async Task Main()
        {
            /*
             *
             * Untuk melakukan testing files
             *
             *
            */
            // string path = """..\..\..\lab\char_lab\fdio""";
            string path = """..\..\..\lab\char_lab\GokuVynStyleP""";
            // string path = """..\..\..\lab\char_lab\karin""";
            // string path = """..\..\..\lab\char_lab\Kratos_KOF""";
            // string path = """..\..\..\lab\char_lab\Naruto Sennin""";
            // string path = """..\..\..\lab\char_lab\The Mask""";


            var manager_obj = new Manager_Class();

            Console.WriteLine("App from C#");

            await manager_obj.Process_Manager(path);
        }
    }
}