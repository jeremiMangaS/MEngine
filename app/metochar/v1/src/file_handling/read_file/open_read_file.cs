using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using v1.src.file_handling.read_file;
using System.Collections.Concurrent;

namespace v1.src.file_handling.read_file
{
    public class Open_Read_File
    {
        /*
         * Tempat menampung data 
        */
        private static ConcurrentDictionary<string, string> data_scan_result = new ConcurrentDictionary<string, string>(); 
        private static string[] _files_list;
        public static string[] files_list
        {
            get
            {
                return _files_list;
            }
        }

        public Open_Read_File(string[] file_list)
        {
            _files_list = file_list;
        }

        public void Scanning_Files()
        {
            /*
             * Pengaturan untuk sistem Parallel
             * - Membatasi hanya 5 pekerja saja
            */
            ParallelOptions parallel_options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 5,  
            };

            Parallel.ForEach(
                _files_list, 
                parallel_options,
                file_process =>
                {
                    /*
                     * Menggunakan StreamReader untuk melakukan scan data di
                     * tiap file
                    */
                    using StreamReader reader = new StreamReader(file_process);
                    Read_File_Requirement read_file_obj = new Read_File_Requirement();
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        /*
                         * Proses yang dilakukan
                        */
                        var data_result = read_file_obj.Scan_Requirement(line);
                        if (data_result != null)
                        {
                            //
                            data_scan_result.TryAdd(data_result.key, data_result.value);
                        }
                        continue;
                    }
                }
            );
        }

        public static void Data_Check()
        {
            foreach (KeyValuePair<string, string> data in data_scan_result)
            {
                Console.WriteLine($"{data.Key} = {data.Value}");    
            }
        }
    }
}