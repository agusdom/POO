using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Y_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo:
            //En programación orientada a objetos,el polimorfismo se refiere a la propiedad
            //por la que es posible enviar mensajes sintaticamente iguales a objetos
            //de tipos distintos.El único requisito que deben cumplir los objetos
            //que se utilizan de manera polimórfica es saber responder al mensaje
            //que se les envia.

            //Primero creamos dos vehículos distintos
            Vehiculo auto = new Auto();//Crea un objeto
            auto.Nombre = "Ford Ranger";
            Vehiculo helicoptero = new Helicoptero();
            helicoptero.Nombre = "Bell AH - 1";
            //Luego creamos un array que contendrá objetos de tipo vehiculo
            Vehiculo[] vehiculos = new Vehiculo[2];
            //Y almacenamos dentro del array los objetos creados anteriormente
            vehiculos[0] = auto;//auto es un objeto de tipo Auto,que a su vez es un vehiculo
            vehiculos[1] = helicoptero;//helicoptero es un objeto de tipo Helicoptero,que a su vez es un vehiculo
            //Finalmente hacemos polimorfismo
            foreach(Vehiculo vehiculo in vehiculos)
            {
                //No me importa si el vehiculo es un auto o un helicoptero,aqui estoy invocando
                //el metodo Estacionarse de cada tipo de vehículo.
                vehiculo.Estacionarse();
            }
            Console.ReadKey();
        }
    }
}
