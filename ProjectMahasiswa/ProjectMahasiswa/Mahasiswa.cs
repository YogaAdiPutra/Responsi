using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa 
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Jenis_Kelamin { get; set; }
    }
    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nim = "18.11.2464";
        mhs1.Nama = "YogaAdiP";
        mhs1.Jenis_Kelamin = "Laki-laki";

        List<Mahasiswa> List = new List<Mahasiswa>();

        List.Add(mhs1);

        Mahasiswa mhs = List[];
        Console.WriteLine("{0},{1} , mhs.Nim, mhs.Nama, mhs.Jenis_Kelamin);

        Console.ReadKey();

    }
}
