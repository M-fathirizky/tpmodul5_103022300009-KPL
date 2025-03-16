using System;


namespace tpmodul5_103022300009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance dari kelas HaloGeneric
            HaloGeneric halo = new HaloGeneric();

            //meminta input
            Console.Write("Masukkan nama Anda: ");
            string inputNama = Console.ReadLine();

            //memanggil method SapaUser
            halo.SapaUser(inputNama);
        }
    }
}