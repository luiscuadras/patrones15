using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Prototype
    {
        static void Main(string[] args)
        {
            Persona P_Uno = new Persona("David");
            Console.Write("El nombre de la persona uno es: ");
            Console.WriteLine(P_Uno.getNombre());
            
            Persona P_Dos = new Persona("");
            P_Dos = P_Uno;
            Console.Write("El nombre de la persona dos es: ");
            Console.WriteLine(P_Dos.getNombre());

            P_Dos.setNombre("Jesus");
            Console.Write("El nombre de la persona uno es: ");
            Console.WriteLine(P_Uno.getNombre());
            
            Console.ReadKey();
        }
    }

    public class Persona
    {
        string nombre = "";
        public Persona(string n)
        {
            this.nombre = n;
        }

        public void setNombre(string n)
        {
            this.nombre = n;
        }

        public String getNombre()
        {
            return this.nombre;
        }
    }

 
}
