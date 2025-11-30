using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PRINCIPAL
{
    public class Class1
    {
        public static void LimpiarZonaInterna()
        {
            for (int y = 5; y < 29; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 101)); // limpia la zona dentro del marco
            }
        }

        public static void SubmenuRegistrar()
        {
            string[] submenu = { "PRODUCTOS", "CLIENTES", "VENDEDORES", "PROVEEDORES" };
            int index = 0;
            ConsoleKeyInfo key;

            while (true)
            {
                // Limpia solo el interior
                LimpiarZonaInterna();

                // Mostrar submenu
                for (int i = 0; i < submenu.Length; i++)
                {
                    Console.SetCursorPosition(10, 6 + i);

                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + submenu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + submenu[i]);
                    }
                }

                // Leer tecla
                key = Console.ReadKey(true);

                // Flechas
                if (key.Key == ConsoleKey.DownArrow)
                    index = (index + 1) % submenu.Length;

                if (key.Key == ConsoleKey.UpArrow)
                    index = (index - 1 + submenu.Length) % submenu.Length;

                // ✔ ESCAPE → SALIR DEL SUBMENÚ
                if (key.Key == ConsoleKey.Escape)
                    return;

                // ENTER → seleccionar
                if (key.Key == ConsoleKey.Enter)
                {
                    LimpiarZonaInterna();
                    Console.SetCursorPosition(0, 10);

                    switch (index)
                    {
                        case 0:
                            menu.productos();
                            break;

                        case 1:
                            menu.clientes();
                            break;

                        case 2:
                            menu.vendedores();
                            break;

                        case 3:
                            menu.proveedores();
                            break;
                    }
                }
            }
        }


        public static void Interfaz()
        {
            // Encabezado
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 103; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            // Título
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(33, 1);
            Console.Write("SISTEMA PARA GESTIONAR VENTAS");
            Console.ResetColor();

            // Líneas superior e inferior
            for (int i = 0; i < 103; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();

                Console.SetCursorPosition(i, 29);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();
            }

            // Líneas laterales
            for (int i = 4; i < 29; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();

                Console.SetCursorPosition(102, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();
            }
        }


        public static int OpcionInterfaz()
        {
            ConsoleKey tecla;
            string[] menu = { "REGISTRAR", "VENTAS", "REPORTES", "MODIFICAR", "AYUDA", "SALIR" };
            int index = 0;

            do
            {
                int left = 0;

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(left, 3);

                    if (index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("     " + menu[i] + "     ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("     " + menu[i] + "     ");
                    }

                    left += 18;
                }

                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index = (index + 1) % menu.Length;
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0) index = menu.Length - 1;
                }

            } while (tecla != ConsoleKey.Enter);

            return index;
        }

        // LIMPIA SOLO EL CUERPO DEL CUADRO

        public static void LimpiarZona(int yInicio, int yFin)
        {
            for (int y = yInicio; y <= yFin; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 100));
            }
        }

        public static void SubmenuReportes()
        {
            string[] submenu = { "PRODUCTOS", "CLIENTES", "VENDEDORES", "PROVEEDORES", "BOLETAS", "FACTURAS", "GUIAS", "PROFORMAS" };
            int index = 0;
            ConsoleKeyInfo key;

            while (true)
            {
                LimpiarZonaInterna();

                // Dibuja el menú
                for (int i = 0; i < submenu.Length; i++)
                {
                    Console.SetCursorPosition(10, 6 + i);

                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + submenu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + submenu[i]);
                    }
                }

                key = Console.ReadKey(true);

                // ← ESCAPE PARA VOLVER AL MENU PRINCIPAL
                if (key.Key == ConsoleKey.Escape)
                    return;

                if (key.Key == ConsoleKey.DownArrow)
                    index = (index + 1) % submenu.Length;

                if (key.Key == ConsoleKey.UpArrow)
                    index = (index - 1 + submenu.Length) % submenu.Length;

                if (key.Key == ConsoleKey.Enter)
                {
                    LimpiarZonaInterna();
                    Console.SetCursorPosition(0, 10);

                    switch (index)
                    {
                        case 0:
                            menu.ListarProductos(menu.totalProductos);
                            break;

                        case 1:
                            menu.ListarClientes(menu.contadorClientes);
                            break;

                        case 2:
                            menu.ListarVendedores(menu.total);
                            break;

                        case 3:
                            menu.ListarProveedores(menu.contadorProveedores);
                            break;

                        case 4:
                            LimpiarZonaInterna();
                            Console.SetCursorPosition(4, 10);
                            Console.Write("El reporte de BOLETAS aun esta en desarrollo...");
                            Console.ReadKey();
                            break;

                        case 5:
                            LimpiarZonaInterna();
                            Console.SetCursorPosition(4, 10);
                            Console.Write("El reporte de FACTURAS aun esta en desarrollo...");
                            Console.ReadKey();
                            break;

                        case 6:
                            LimpiarZonaInterna();
                            Console.SetCursorPosition(4, 10);
                            Console.Write("El reporte de GUIAS aun esta en desarrollo...");
                            Console.ReadKey();
                            break;

                        case 7:
                            LimpiarZonaInterna();
                            Console.SetCursorPosition(4, 10);
                            Console.Write("El reporte de PROFORMAS aun esta en desarrollo...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }

        public static void SubmenuVentas()
        {
            string[] submenu = { "BOLETA", "FACTURA", "GUIA REM", "PROFORMA" };
            int index = 0;
            ConsoleKeyInfo key;

            while (true)
            {
                LimpiarZonaInterna();

                // Mostrar opciones
                for (int i = 0; i < submenu.Length; i++)
                {
                    Console.SetCursorPosition(10, 6 + i);

                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + submenu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + submenu[i]);
                    }
                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                    return;

                if (key.Key == ConsoleKey.DownArrow)
                    index = (index + 1) % submenu.Length;

                if (key.Key == ConsoleKey.UpArrow)
                    index = (index - 1 + submenu.Length) % submenu.Length;

                if (key.Key == ConsoleKey.Enter)
                {
                    LimpiarZonaInterna();
                    Console.SetCursorPosition(0, 10);

                    switch (index)
                    {
                        case 0:
                            menu.Boleta(); // <--- AGREGA ESTA LÍNEA

                            break;

                        case 1:
                            Console.SetCursorPosition(10, 10);
                            Console.WriteLine("FACTURA en desarrollo...");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.SetCursorPosition(10, 10);
                            Console.WriteLine("GUÍA REM en desarrollo...");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.SetCursorPosition(10, 10);
                            Console.WriteLine("PROFORMA en desarrollo...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}
