using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PRINCIPAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(140, 40);
            Console.SetBufferSize(140, 40);

            int opc;

            do
            {
                Console.Clear();
                Class1.Interfaz();            // Dibuja marco y encabezado
                opc = Class1.OpcionInterfaz(); // Selecciona opción SIN limpiar pantalla

                // Limpiar solo la zona de contenido (dentro del cuadro)
                Class1.LimpiarZona(5, 28);
                Console.SetCursorPosition(10, 10);

                switch (opc)
                {
                    case 0:
                        Class1.SubmenuRegistrar();
                        break;
                    case 1:
                        Class1.SubmenuVentas();
                        break;
                    case 2:
                        Class1.SubmenuReportes();
                        break;

                    case 3:
                        Console.SetCursorPosition(10, 10);
                        Console.Write("LA OPCION DE MODIFICAR AUN ESTA EN DESARROLLO");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.SetCursorPosition(10, 10);
                        Console.Write("LA OPCION DE AYUDA AUN ESTA EN DESARROLLO");
                        Console.ReadKey();
                        break;

                    case 5:
                        for (int y = 5; y < 29; y++)
                        {
                            Console.SetCursorPosition(1, y);
                            Console.Write(new string(' ', 101));
                        }
                        Console.SetCursorPosition(10, 10);
                        Console.Write("SALISTE DEL PROGRAMA MUCHAS GRACIAS POR SU INTERACCIÓN");
                        break;
                }

            } while (opc != 5);

            Console.SetCursorPosition(0, 30);
        }
    }
}
