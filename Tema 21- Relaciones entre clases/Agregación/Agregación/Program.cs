using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia materia = new Materia("Laboratorio 2");

            Tema tema1 = new Tema("Orientación a objetos");
            Tema tema2 = new Tema("Windows Form");

            materia.AgregarTema(tema1);
            materia.AgregarTema(tema2);

            foreach(Tema t in materia.Temas)
            {
                Console.WriteLine(materia.Nombre+":"+t.Nombre);
            }

            tema1.Materia = materia;
            tema2.Materia = materia;

            Console.WriteLine(tema1.Nombre +":"+tema1.Materia.Nombre);
            Console.WriteLine(tema2.Nombre + ":" + tema2.Materia.Nombre);
            Console.ReadKey();
        }
    }
}
