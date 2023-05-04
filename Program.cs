using System;
using LabClases1.Clases;

namespace LabClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           A p = new A();
            A s = new A("Parametro X");
            B t = new B();

            p.MostrarNombre();
            p.M1();
            p.M2();
            p.M3();

            s.MostrarNombre();
            s.M1();
            s.M2();
            s.M3();

            t.MostrarNombre();
            t.M1();
            t.M2();
            t.M3();
            t.M4();
        }
    }
}
