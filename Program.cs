using System;

namespace tpmodul5_103022300009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance dari kelas HaloGeneric
            HaloGeneric halo = new HaloGeneric();

            // Meminta input nama
            Console.Write("Masukkan nama Anda: ");
            string inputNama = Console.ReadLine();

            // Memanggil method SapaUser
            halo.SapaUser(inputNama);

            // Meminta input NIM
            Console.Write("Masukkan NIM Anda: ");
            string nim = Console.ReadLine();

            // Membuat instance kelas DataGeneric
            DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

            // Memanggil method PrintData
            dataGeneric.PrintData();
        }
    }
}
