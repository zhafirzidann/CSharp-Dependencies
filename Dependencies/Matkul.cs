using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencies
{
    class Matkul
    {
        public void info(string pesan)
        {
            Console.WriteLine("Mata Kuliah : " +pesan);
        }

        public void total(int total)
        {
            Console.WriteLine("SKS : " + total);
        }

        public void mahasiswa(string pesan)
        {
            Console.WriteLine("Nama Mahasiswa : " + pesan);
        }
    }
}
