using System;

namespace Dependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Matkul matkul = new Matkul();
            Mahasiswa mahasiswa = new Mahasiswa(matkul);
            mahasiswa.pelajaran();
            mahasiswa.sks();
            mahasiswa.mahasiswa();
        }
    }
}
