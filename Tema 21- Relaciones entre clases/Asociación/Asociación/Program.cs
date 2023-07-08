using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia materia = new Materia("Laboratorio 2");
            Materia materia2 = new Materia("Laboratorio 3");

            ProfesorTitular profesor = new ProfesorTitular("Jesús Arce");

            //materia.Profesor = profesor;
            //materia2.Profesor = profesor;

            profesor.AgregarMateria(materia);
            profesor.AgregarMateria(materia2);

            foreach(Materia m in profesor.Materias)
            {
                Console.WriteLine(m.Nombre);
            }

            //Console.WriteLine(materia.Nombre+":"+materia.Profesor.Nombre);
            //Console.WriteLine(materia2  .Nombre+ ":"+ materia2.Profesor.Nombre);
            Console.ReadKey();

        }
    }
}
