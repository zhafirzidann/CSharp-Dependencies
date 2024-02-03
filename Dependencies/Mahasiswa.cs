using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencies
{
    class Mahasiswa
    {
        private Matkul matkul;

        public Mahasiswa(Matkul matkul)
        {
            this.matkul = matkul;
        }

        public void pelajaran()
        {
            this.matkul.info("Pemrograman");
        }
        public void sks()
        {
            this.matkul.total(2);
        }

        public void mahasiswa()
        {
            this.matkul.mahasiswa("M. Zhafir Zaydan");
        }
    }
}
