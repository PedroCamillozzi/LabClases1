using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases1.Clases
{
    internal class B : A
    {
        public B() : base("Instancia de B") { }

        public void M4()
        {
            Console.WriteLine("Metodo del hijo Invocado");
        }
        
    }
}
