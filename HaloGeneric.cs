using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300009
{
    class HaloGeneric
    {
        //method bernama SapaUser
        public void SapaUser<T>(T X)
        {
            //output "Halo user X" dimana X merupakan input
            Console.WriteLine($"Halo user {X}");
        }

    }

}
    
