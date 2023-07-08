using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado = new Soldado();
            Menu1.MenuPrimero(ref soldado);
           
            Console.ReadKey();


        }

        internal class Menu1
        {
            public static void MenuPrimero(ref Soldado soldado)
            {
                
                int opcion = 0;
                Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado==-\n" +
                    "\n" +
                                  "¿Qué desea hacer?\n" +
                                   "(presione el número correspondiente a la opción del menú)\n" +
                                   "\n" +
                                    "1-Recorrer arma\n" +
                                    "2-Dejar arma\n" +
                                    "3-Disparar\n" +
                                    "4-Ver arma en uso\n" +
                                    "5-Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Menu2.MenuSegundo(ref soldado);
                        break;
                    case 2:
                        soldado.DejarArma();
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    case 3:
                        soldado.Disparar();
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    case 4:
                        soldado.VerArma();
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    default:
                        Environment.Exit(2);
                        break;
                }
            }
        }
      
        internal class Menu2
        {
            public static void MenuSegundo(ref Soldado soldado)
            {
                
                int opcion = 0;
                Console.WriteLine("Por favor, escoja el arma que desea utilizar-\n"+
                                   "\n" +
                                    "1-Revolver\n" +
                                    "2-Rifle\n" +
                                    "3-Escopeta\n" +
                                    "4-Volver atras");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Revolver revolver = new Revolver();
                        soldado.RecogerArma(revolver);
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    case 2:
                        Rifle rifle = new Rifle();
                        soldado.RecogerArma(rifle);
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    case 3:
                        Escopeta escopeta = new Escopeta();
                        soldado.RecogerArma(escopeta);
                        Menu1.MenuPrimero(ref soldado);
                        break;
                    default:
                        Menu1.MenuPrimero(ref soldado);
                        break;
                }
            }
        }

    }
}
