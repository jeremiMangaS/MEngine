using System;
using System.Net;
using System.Reflection.Emit;

namespace v1.src.file_handling.read_file
{
    public class Read_File_Requirement
    {
        private bool _label_status = false;
        // private string[] data_line = new string[2];
        public record data_line(string key, string value);

        private static readonly string[] label_list =
        {
            /*
             * Daftar label yang dapat diambil datanya
            */
            "[data]", "[size]", "[velocity]", "[movement]", "[info]"
        };

        public data_line Scan_Requirement(string line)
        {
            /*
             * Menghapus/Mengabaikan komentar dimana Komentar diawali dengan simbol ';'
            */
            line = line.Split(';')[0];

            /*
             * Memeriksa line kosong
            */
            if (string.IsNullOrWhiteSpace(line))
            {
                _label_status = false;
                return null;
            }

            /*
             * Memeriksa apakah data tersebut termasuk ke dalam bagian label
             * yang terdaftar, jika iya maka ambil datanya jika tidak maka
             * abaikan saja
            */
            Func<string, bool> __label_check = line => {
                foreach(string label in label_list)
                {
                    if (line == label) {
                        return true;
                    }
                }
                return false;
            };
            if (__label_check(line.Trim().ToLower()))
            {
                _label_status = true;
            }

            if (!_label_status)
            {
                return null;
            }

            // int equal_index = line.IndexOf('=');
            /*
             * Jika memenuhi syarat, maka ambil datanya
            */
            if (_label_status && line.Contains('='))
            {
                string[] line_part = line.Split('=', 2);
                return new data_line(line_part[0].Trim(), line_part[1].Trim());
            }
            
            return null;
        }
    }
}