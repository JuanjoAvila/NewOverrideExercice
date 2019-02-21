using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideExercice
{
    class BaseClass
    {
        //Metodo uno virutal para poder hacer el override en la clase secundaria
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        //Metodo dos virutal para poder hacer el override en la clase secundaria
        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }
}
