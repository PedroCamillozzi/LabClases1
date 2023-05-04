using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases1.Clases
{
    class A
    {
        string nombreInstancia;
        public string NombreInstancia
        {
            
            get
            {
                return nombreInstancia;
            }
            set
            {
                nombreInstancia = value;
            }
        }



        public A(string nombreInstancia)
        {
            this.NombreInstancia = nombreInstancia;
        }


        public A()
        {
            this.NombreInstancia = "Instancia Sin Nombre";
        }

        public void MostrarNombre()
        {
            Console.WriteLine(nombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("Se invocó por M1");
        }
        public void M2()
        {
            Console.WriteLine("Se invocó por M2");
        }
        public void M3()
        {
            Console.WriteLine("Se invocó por M3");
        }
    }
}
