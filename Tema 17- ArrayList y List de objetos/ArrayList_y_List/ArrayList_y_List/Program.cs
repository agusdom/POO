using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_y_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYlIST DE OBJETOS
            //Un arraylist de objetos lo podemos usar cuando tenemos que guardar
            //objetos de distintos tipo en la colección.
            #region ARRAYLIST DE OBJETOS
            Console.WriteLine("- - - - - - ARRAYLIST DE OBJETOS - - - - - -");

            //Primero creamos un arraylist
            ArrayList arrayListDeObjetos = new ArrayList();

            //Creamos un objeto de cada clase y asignamos un valor a su atributo
            Animal perro = new Animal();
            perro.nombre = "Ovejero Aleman";

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.nombre = "Automovil Chevrolet Corsa";

            //Agregamos los objetos al arraylist
            arrayListDeObjetos.Add(perro);
            arrayListDeObjetos.Add(vehiculo);

            //Recorremos el arraylist
            foreach (object item in arrayListDeObjetos)
            {
                //Como no sabemos de qué clase es el objeto que se encuentra
                //en el arraylist,necesitamos obtener el Type(tipo de objeto).
                Type tipo = item.GetType();

                switch (tipo.Name)
                {
                    case "Animal":
                        Animal objetoClaseAnimal = (Animal)item;
                        Console.WriteLine(objetoClaseAnimal.nombre);
                        break;
                    case "Vehiculo":
                        Vehiculo objetoClaseVehiculo = (Vehiculo)item;
                        Console.WriteLine(objetoClaseVehiculo.nombre);
                        break;
                        //Si el objeto es de cualquier otro tipo
                    default:
                        break;//Lo ignoramos y pasamos al siguiente objeto
                }
            }
            #endregion

            //lIST DE OBJETOS
            //Un list de objetos lo podemos usar cuando tenemos que guardar
            //objetos del mismo tipo en la colección.
            #region LIST DE OBJETOS
            Console.WriteLine("- - - - - - LIST DE OBJETOS - - - - - -");

            //Primero creamos un list de un tipo determinado
            List<Animal> ListDeObjetos = new List<Animal>();

            //Creamos un objeto de tipo animal
            Animal dog = new Animal();
            dog.nombre = "Ovejero Aleman";

            Animal cat = new Animal();
            cat.nombre = "Gato simes";

            Animal tiger = new Animal();
            tiger.nombre = "Tipo de vengala";

            //Agregamos los objetos al list
            ListDeObjetos.Add(dog);
            ListDeObjetos.Add(cat);
            ListDeObjetos.Add(tiger);

            //Recorremos el list
            foreach (Animal item in ListDeObjetos)
            {
               Console.WriteLine(item.nombre);
            }
            
            #endregion
            Console.ReadKey();
        }
      
    }

    class Animal{
        public String nombre;
    }

    class Vehiculo{
        public String nombre;
    }
}
