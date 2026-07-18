using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using v1.services.sff_extract.first_layer;

namespace v1.src.file_handling.extract_file
{
    public class Open_Extract_File
    {
        private string[] _sff_files_list;
        private string[] _snd_files_list;
        private string[] _act_files_list;
        private  readonly string[] _files_list;

        public ReadOnlyCollection<string> files_list => Array.AsReadOnly(_files_list);
        public Open_Extract_File(string[] files_list)
        {
            _files_list = files_list;
        }

        private void Assets_Sorting(string[] files_list)
        {
            List<string> sff_list = new List<string>();
            List<string> snd_list = new List<string>();
            List<string> act_list = new List<string>();
            foreach (string file in files_list)
            {
                string file_ext = Path.GetExtension(file);

                switch (file_ext)
                {
                    case ".sff" :
                        sff_list.Add(file);
                        break;
                    case ".snd" :
                        snd_list.Add(file);
                        break;
                    case ".act" :
                        act_list.Add(file);
                        break;

                }
            }
            _sff_files_list = sff_list.ToArray();
            _snd_files_list = snd_list.ToArray();
            _act_files_list = act_list.ToArray();
        }

        public void Extraction_Manager()
        {
            /*
             * Mengelompokkan file file yang perlu di ekstrak menjadi beberapa 
             * array masing masing jenis file
             * Pengelompokkan : 
             *  - .sff : Untuk sprite gambar
             *  - .snd : Untuk suara
             *  - .act : Untuk palette warna
            */
            Assets_Sorting(_files_list);
            
            /*
             * Testing : Hasil dari file .sff yang ditemukan
            */
            // _testing();

            /*
             * Proses utama untuk ekstraksi, dipecah per jenis asset 
             * untuk dilakukan secara bersamaan
            */
            Task extract_sff_process = Task.Run(() =>
            {
                // Proses untuk ekstraksi filie .sff
                SFF_Extraction sff_extract_obj = new SFF_Extraction(_sff_files_list);
                sff_extract_obj._Decompile_Process();
            });
        }

        private void _testing()
        {
            int i = 1;
            foreach (string file in _sff_files_list)
            {
                Console.WriteLine($"{i}{file}");
                i++;
            }
        }
    }
}