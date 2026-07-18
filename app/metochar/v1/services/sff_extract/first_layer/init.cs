using System.Diagnostics;
using System;

namespace v1.services.sff_extract.first_layer
{
    public class SFF_Extraction
    {
        private string[] _sff_files_list;
        // private Process process;
        // private string _sff_decompile_path;
        public SFF_Extraction(string[] files_list)
        {
            _sff_files_list = files_list;
            // _sff_decompile_path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\..\..\external_tools\sff_decompiler\sffdecompiler.exe ..\..\..\..\..\..\lab\char_lab\fdio\hasil_ekstraksi\fdio.sff"));
            // process = new Process();
        }

        public void _Decompile_Process()
        {
            /*
             * Testing : Melihat isi data list
            */
            // _List_Data_Check();

            string sff_decompiler_path = @"..\..\..\external_tools\sff_decompiler\sffdecompiler.exe";
            string sff_file_path = @"..\..\..\lab\char_lab\fdio\hasil_ekstraksi\fdio.sff";

            Process process = new Process();

            process.StartInfo.FileName = sff_decompiler_path;
            process.StartInfo.Arguments = $"\"{sff_file_path}\""; // Memastikan jika path memiliki penamaan yang mengandung spasi
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            /*
             * Menangkap Output baik berhasli maupun error
            */
            string output_success = process.StandardOutput.ReadToEnd();
            string output_error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            Console.WriteLine($"Output : {output_success}\nError : {output_error}");
        }

        private void _List_Data_Check()
        {
            foreach(string file in _sff_files_list)
            {
                Console.WriteLine(file);
            }
        }
    }
}