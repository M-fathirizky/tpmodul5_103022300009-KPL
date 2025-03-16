using System;

namespace tpmodul5_103022300009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meminta input
            Console.Write("Masukkan NIM Anda: ");
            string nim = Console.ReadLine();

            // Membuat instance kelas DataGeneric
            DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

            // Memanggil method PrintData 
            dataGeneric.PrintData();

        }
    }
}