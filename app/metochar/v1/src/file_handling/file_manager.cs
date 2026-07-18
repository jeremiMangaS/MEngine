using System.IO;
using System.Threading;
using System.Collections.Generic;
using v1.src.file_handling.extract_file;
using v1.src.file_handling.read_file;
using System.Threading.Tasks;

namespace v1.src.file_handling
{
    public class File_Manager
    {
        private static Open_Read_File? _read_file_obj;
        private static Open_Extract_File? _extract_file_obj;
        public static async Task File_List_Managing(string[] file_list)
        {
            /*
             *
             * Mengatur komunikasi dan kerja antar 2 proses yaitu : 
             * - Read file : Untuk melakukan pengambilan data karakter
             * - Extract file : Untuk mengekstrak file file asset karakter
             *
            */

            /*
             * Mengatur pembagian file untuk tugas
            */
            _File_Sorting(file_list);

            /*
             * Mengatur proses kerja paralel antar read file dan extract file
            */
            await _Process_Managing();
        }

        private static void _File_Sorting(string[] file_list)
        {
            List<string> extract_file_list = new List<string>();
            List<string> read_file_list = new List<string>(); 

            foreach (string file in file_list)
            {
                string file_ext = Path.GetExtension(file);
                if (file_ext == ".act" || file_ext == ".snd" || 
                file_ext == ".air" || file_ext == ".sff")
                {
                    extract_file_list.Add(file);
                } else if (file_ext == ".def" || file_ext == ".cns" || 
                file_ext == ".st" || file_ext == ".cmd" || file_ext == ".dat" || 
                file_ext == ".txt")
                {
                    read_file_list.Add(file);
                }
            }

            /*
             * Mengirim data yang sudah disortir
            */
            _read_file_obj = new Open_Read_File(read_file_list.ToArray());
            _extract_file_obj = new Open_Extract_File(extract_file_list.ToArray());
        }

        private static async Task _Process_Managing()
        {
            Task read_process = Task.Run(() =>
            {
                _read_file_obj.Scanning_Files();
            });
            Task extract_process = Task.Run(() =>
            {
                _extract_file_obj.Extraction_Manager();
            });
            
            /*
             * Menunggu semua proses selesai untuk melanjutkan ke prooses berikutnya 
             * : Parsing data menjadi file .json
            */
            await Task.WhenAll(read_process, extract_process);

            // Open_Read_File.Data_Check();
        }
    }
}