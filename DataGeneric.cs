using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300009
{
    class DataGeneric<T>
    {
        // Properti data dengan tipe data generik
        private T data;

        // Konstruktor
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method PrintData 
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }
}
