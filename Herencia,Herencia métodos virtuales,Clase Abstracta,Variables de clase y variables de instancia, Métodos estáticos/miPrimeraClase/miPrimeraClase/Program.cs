using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.mostrarMensaje();

            Point3D p3d = new Point3D();
            p3d.mostrarMensaje();

            ClaseDerivada cd = new ClaseDerivada();
            cd.MostrarMensaje();
            cd.DecirHola();

            //Variables de instancia
            //es necesario acceder a ellas a traves del objeto.
            //y existe uno por cada objeto de la clase
            Variables variable1 = new Variables();
            variable1.numero = 8;

            //Variables de clase o estaticas
            //no es necesario acceder a ellas a traves del objeto.
            //simplemente se acceden anteponiendo el nombre de la clase
            //y existe solo una para todos los objetos de la clase
            Variables.edad = 34;
            Console.ReadKey();
        }
    }
}
