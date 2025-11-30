using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PRINCIPAL
{
    public class menu
    {
        // Arreglos para proveedores
        public static string[] codigo_proveedor = new string[50];
        public static string[] empresa_proveedor = new string[50];
        public static string[] ruc_proveedor = new string[50];
        public static string[] representante_proveedor = new string[50];
        public static string[] telefono_proveedor = new string[50];
        public static string[] direccion_proveedor = new string[50];
        public static string[] ciudad_proveedor = new string[50];
        public static int contadorProveedores = 0;

        // arreglos para clientes
        public static string[] nombre_cliente = new string[50];
        public static string[] dni_cliente = new string[50];
        public static string[] apellidos_cliente = new string[50];
        public static string[] telefono_cliente = new string[50];
        public static string[] email_cliente = new string[50];
        public static string[] direccion_cliente = new string[50];
        public static int contadorClientes = 0;

        // Arreglos paralelos para almacenar datos( vendedores )
        public static string[] codigos = new string[50];
        public static string[] nombres = new string[50];
        public static string[] apellidos = new string[50];
        public static double[] sueldos = new double[50];
        public static string[] telefonos = new string[50];
        public static int total = 0;



        //Arreglos para productos
        public static string[] codigos_producto = new string[50];
        public static string[] nombres_producto = new string[50];
        public static string[] categorias_producto = new string[50];
        public static int[] stocks_producto = new int[50];
        public static double[] precios_producto = new double[50];
        public static int totalProductos = 0;




        public static void productos()
        {
            string opcion;

            do
            {
                // Limpia la zona interna
                Class1.LimpiarZonaInterna();

                // Verifica límite
                if (totalProductos >= 50)
                {
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("Error: Límite de 50 productos alcanzado");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    return;
                }

                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR PRODUCTO");

                // ====== CÓDIGO (único) ======
                string codigo;
                bool valido;
                do
                {
                    for (int y = 8; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 digitos): ");
                    codigo = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (codigo.Length == 0)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Error: El código no puede estar vacío");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que no exista
                    for (int i = 0; i < totalProductos; i++)
                    {
                        if (codigos_producto[i] == codigo)
                        {
                            Console.SetCursorPosition(5, 9);
                            Console.WriteLine("Error: El código ya existe");
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== NOMBRE (único, solo letras) ======
                string nombre;
                do
                {
                    for (int y = 9; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 digitos): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (nombre.Length == 0)
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Error: El nombre no puede estar vacío");
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que solo contenga letras
                    bool tieneNumero = false;
                    for (int i = 0; i < nombre.Length; i++)
                    {
                        if (nombre[i] >= '0' && nombre[i] <= '9')
                        {
                            tieneNumero = true;
                            break;
                        }
                    }

                    if (tieneNumero)
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Error: El nombre solo debe contener letras");
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    if (!valido) continue;

                    // Validar que no exista (sin importar mayúsculas/minúsculas)
                    for (int i = 0; i < totalProductos; i++)
                    {
                        if (nombres_producto[i].ToLower() == nombre.ToLower())
                        {
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Error: Ese nombre ya existe");
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== CATEGORÍA (solo letras) ======
                string categoria;
                do
                {
                    for (int y = 10; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 digitos): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: " + nombre);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Categoría: ");
                    categoria = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (categoria.Length == 0)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: La categoría no puede estar vacía");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que solo contenga letras
                    bool tieneNumero = false;
                    for (int i = 0; i < categoria.Length; i++)
                    {
                        if (categoria[i] >= '0' && categoria[i] <= '9')
                        {
                            tieneNumero = true;
                            break;
                        }
                    }

                    if (tieneNumero)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: La categoría solo debe contener letras");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }
                } while (!valido);

                // ====== STOCK ======
                int stock = 0;
                string inputStock;
                do
                {
                    for (int y = 11; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 digitos): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: " + nombre);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Categoría: " + categoria);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Stock: ");

                    inputStock = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (inputStock.Length == 0)
                    {
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Error: El stock no puede estar vacío");
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que todos los caracteres sean dígitos
                    for (int i = 0; i < inputStock.Length; i++)
                    {
                        if (inputStock[i] < '0' || inputStock[i] > '9')
                        {
                            Console.SetCursorPosition(5, 12);
                            Console.WriteLine("Error: El stock debe ser un número positivo");
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }

                    // Si es válido, convertir a número
                    if (valido)
                    {
                        stock = int.Parse(inputStock);
                    }

                } while (!valido);

                // ====== PRECIO ======
                double precio = 0;
                string inputPrecio;
                do
                {
                    for (int y = 12; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 digitos): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: " + nombre);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Categoría: " + categoria);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Stock: " + stock);
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Precio unitario: ");

                    inputPrecio = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (inputPrecio.Length == 0)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El precio no puede estar vacío");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que sea un número válido (dígitos y un punto decimal)
                    int contadorPuntos = 0;
                    for (int i = 0; i < inputPrecio.Length; i++)
                    {
                        if (inputPrecio[i] == '.')
                        {
                            contadorPuntos++;
                            if (contadorPuntos > 1)
                            {
                                Console.SetCursorPosition(5, 13);
                                Console.WriteLine("Error: El precio debe ser un número válido");
                                Console.SetCursorPosition(5, 14);
                                Console.WriteLine("Presione Enter para intentar de nuevo...");
                                Console.ReadKey();
                                valido = false;
                                break;
                            }
                        }
                        else if (inputPrecio[i] < '0' || inputPrecio[i] > '9')
                        {
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Error: El precio debe ser un número válido");
                            Console.SetCursorPosition(5, 14);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }

                    // Si es válido, convertir a número y validar que sea mayor a 0
                    if (valido)
                    {
                        precio = double.Parse(inputPrecio);

                        if (precio <= 0)
                        {
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Error: El precio debe ser mayor a 0");
                            Console.SetCursorPosition(5, 14);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                        }
                    }

                } while (!valido);

                // ====== GUARDAR PRODUCTO ======
                codigos_producto[totalProductos] = codigo;
                nombres_producto[totalProductos] = nombre;
                categorias_producto[totalProductos] = categoria;
                stocks_producto[totalProductos] = stock;
                precios_producto[totalProductos] = precio;
                totalProductos++;

                Console.SetCursorPosition(5, 14);
                Console.Write("Producto registrado correctamente!.");
                Console.SetCursorPosition(5, 15);
                Console.Write("¿Desea registrar otro producto? (s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion == "s");
        }

        public static int clientes()
        {

            string nombre, dni, apellidos, telefono, email, direccion, opcion;
            bool dnivalido, valido;


            do
            {
                do//nombres
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Nombres: ");
                    nombre = Console.ReadLine();
                    valido = SoloLetras(nombre);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El nombre solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);


                do//apellidos
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Apellidos: ");
                    apellidos = Console.ReadLine();
                    valido = SoloLetras(apellidos);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El apellido solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);


                do//telefono
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Teléfono (9 dígitos): ");
                    telefono = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(telefono))
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono solo debe contener números");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar longitud exacta
                    if (telefono.Length != 9)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }

                    for (int i = 0; i < telefono_cliente.Length; i++)
                    {
                        if (telefono_cliente[i] == telefono)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El teléfono ya existe.");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }

                } while (!valido);


                bool emailValido;
                do//email
                {
                    emailValido = true;

                    Class1.LimpiarZonaInterna();
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("EMAIL: ");
                    email = Console.ReadLine();
                    for (int i = 0; i < email_cliente.Length; i++)
                    {
                        if (email_cliente[i] == email)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El email ya existe.");
                            Console.ReadKey();
                            emailValido = false;
                            break;
                        }
                    }

                } while (!emailValido);

                bool direccionValida;
                do//direccion
                {
                    direccionValida = true;
                    Class1.LimpiarZonaInterna();
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("DIRECCIÓN: ");
                    direccion = Console.ReadLine();

                    for (int i = 0; i < direccion_cliente.Length; i++)
                    {
                        if (direccion_cliente[i] == direccion)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("La dirección ya existe.");
                            Console.ReadKey();
                            direccionValida = false;
                            break;
                        }
                    }

                } while (!direccionValida);

                do//DNI
                {
                    dnivalido = true;

                    Class1.LimpiarZonaInterna();
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("DNI: ");
                    dni = Console.ReadLine();

                    // Validar formato del DNI: 8 dígitos numéricos
                    if (dni.Length != 8 || !int.TryParse(dni, out _))
                    {

                        Console.SetCursorPosition(5, 8);
                        Console.Write("DNI debe tener 8 dígitos numéricos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione una tecla para volver a intentarlo");
                        Console.ReadKey();
                        dnivalido = false;
                        continue;
                    }

                    // Validar que no exista en el array
                    for (int i = 0; i < dni_cliente.Length; i++)
                    {
                        if (dni_cliente[i] == dni)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El DNI ya existe. Intente con otro.");
                            Console.ReadKey();
                            dnivalido = false;
                            break;
                        }
                    }

                } while (!dnivalido);

                for (int i = 0; i < nombre_cliente.Length; i++)
                {
                    if (nombre_cliente[i] == null)
                    {
                        nombre_cliente[i] = nombre;
                        apellidos_cliente[i] = apellidos;
                        telefono_cliente[i] = telefono;
                        email_cliente[i] = email;
                        direccion_cliente[i] = direccion;
                        dni_cliente[i] = dni;
                        contadorClientes++;
                        break;
                    }
                }


                Console.SetCursorPosition(6, 10);
                Console.Write("Cliente registrado correctamente!.");
                Console.SetCursorPosition(6, 11);
                Console.Write("Desea incribir a otro vendedor?(s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {

                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione enter para volver al menu principal...");
                    Console.ReadLine();
                }
            } while (opcion == "s");

            return contadorClientes;

        }
        public static int vendedores()
        {
            string opcion;

            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }


                if (total >= 50)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("Error: Límite de 50 vendedores alcanzado");
                    Console.ReadKey();
                }

                // Código (debe tener exactamente 11 dígitos y no repetido)
                string codigo;
                bool valido;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(7, 7);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 dígitos): ");
                    codigo = Console.ReadLine();
                    valido = true;



                    // Validar longitud exacta
                    if (codigo.Length != 11)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: El código debe tener exactamente 11 dígitos");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que no exista
                    for (int i = 0; i < total; i++)
                    {
                        if (codigos[i] == codigo)
                        {
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Error: El código ya existe");
                            Console.SetCursorPosition(5, 14);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // Nombres (solo letras)
                string nom;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(7, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Nombres: ");
                    nom = Console.ReadLine();
                    valido = SoloLetras(nom);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Error: El nombre solo debe contener letras");
                        Console.SetCursorPosition(5, 10);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // Apellidos (solo letras)
                string ape;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Apellidos: ");
                    ape = Console.ReadLine();
                    valido = SoloLetras(ape);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El apellido solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // Sueldo (solo números positivos)
                double sueldo;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Sueldo: ");
                    string sueldoTexto = Console.ReadLine();
                    valido = double.TryParse(sueldoTexto, out sueldo);

                    if (!valido || sueldo < 0)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El sueldo debe ser un número ");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadLine();
                        valido = false;
                    }
                } while (!valido);

                // Teléfono (debe tener exactamente 9 dígitos)
                string tel;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Teléfono (9 dígitos): ");
                    tel = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(tel))
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono solo debe contener números");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar longitud exacta
                    if (tel.Length != 9)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }

                    for (int i = 0; i < total; i++)
                    {
                        if (telefonos[i] == tel)
                        {
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Error: El teléfono ya existe");
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }

                } while (!valido);

                // Guardar
                codigos[total] = codigo;
                nombres[total] = nom;
                apellidos[total] = ape;
                sueldos[total] = sueldo;
                telefonos[total] = tel;
                total++;

                Console.SetCursorPosition(6, 10);
                Console.Write("Vendedor registrado!");
                Console.SetCursorPosition(6, 11);
                Console.Write("Desea incribir a otro vendedor?(s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {

                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione enter para volver al menu principal...");
                    Console.ReadLine();
                }

            } while (opcion == "s");
            return total;
        }

        public static int proveedores()
        {
            string opcion;

            do
            {
                // Verificar si ya llegamos al límite de 50 proveedores
                if (contadorProveedores >= 50)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("Error: Límite de 50 proveedores alcanzado");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    return contadorProveedores;
                }

                // ====== CÓDIGO DEL PROVEEDOR (alfanumérico, único, 11 caracteres) ======
                string codigo;
                bool valido;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): ");
                    codigo = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (codigo.Length == 0)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Error: El código no puede estar vacío");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que tenga exactamente 11 caracteres
                    if (codigo.Length != 11)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Error: El código debe tener exactamente 11 caracteres");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que el código no exista (único)
                    for (int i = 0; i < contadorProveedores; i++)
                    {
                        if (codigo_proveedor[i] == codigo)
                        {
                            Console.SetCursorPosition(5, 9);
                            Console.WriteLine("Error: El código ya existe");
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== EMPRESA PROVEEDORA (solo letras) ======
                string empresa;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: ");
                    empresa = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (empresa.Length == 0)
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Error: La empresa no puede estar vacía");
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que solo contenga letras y espacios
                    if (!SoloLetras(empresa))
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Error: La empresa solo debe contener letras");
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // ====== NÚMERO DE RUC (11 dígitos, único) ======
                string ruc;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: " + empresa);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("RUC (11 dígitos): ");
                    ruc = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (ruc.Length == 0)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: El RUC no puede estar vacío");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que solo sean números
                    if (!SoloNumeros(ruc))
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: El RUC solo debe contener números");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que tenga exactamente 11 dígitos
                    if (ruc.Length != 11)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: El RUC debe tener exactamente 11 dígitos");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que el RUC no exista (único)
                    for (int i = 0; i < contadorProveedores; i++)
                    {
                        if (ruc_proveedor[i] == ruc)
                        {
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Error: El RUC ya existe");
                            Console.SetCursorPosition(5, 12);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== REPRESENTANTE ======
                string representante;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: " + empresa);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("RUC (11 dígitos): " + ruc);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Representante: ");
                    representante = Console.ReadLine();
                    valido = SoloLetras(representante);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Error: El representante solo debe contener letras");
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // ====== TELÉFONO (9 dígitos, solo números) ======
                string telefono;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: " + empresa);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("RUC (11 dígitos): " + ruc);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Representante: " + representante);
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Teléfono (9 dígitos): ");
                    telefono = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (telefono.Length == 0)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El teléfono no puede estar vacío");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que solo sean números (IMPORTANTE)
                    if (!SoloNumeros(telefono))
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El teléfono solo debe contener números");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que tenga exactamente 9 dígitos
                    if (telefono.Length != 9)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // ====== DIRECCIÓN ======
                string direccion;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: " + empresa);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("RUC (11 dígitos): " + ruc);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Representante: " + representante);
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Teléfono (9 dígitos): " + telefono);
                    Console.SetCursorPosition(5, 13);
                    Console.Write("Dirección: ");
                    direccion = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (direccion.Length == 0)
                    {
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Error: La dirección no puede estar vacía");
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // ====== CIUDAD ======
                string ciudad;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR PROVEEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código del proveedor (11 caracteres): " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Empresa proveedora: " + empresa);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("RUC (11 dígitos): " + ruc);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Representante: " + representante);
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Teléfono (9 dígitos): " + telefono);
                    Console.SetCursorPosition(5, 13);
                    Console.Write("Dirección: " + direccion);
                    Console.SetCursorPosition(5, 14);
                    Console.Write("Ciudad: ");
                    ciudad = Console.ReadLine();
                    valido = SoloLetras(ciudad);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("Error: La ciudad solo debe contener letras");
                        Console.SetCursorPosition(5, 16);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // ====== GUARDAR PROVEEDOR EN LOS ARREGLOS ======
                codigo_proveedor[contadorProveedores] = codigo;
                empresa_proveedor[contadorProveedores] = empresa;
                ruc_proveedor[contadorProveedores] = ruc;
                representante_proveedor[contadorProveedores] = representante;
                telefono_proveedor[contadorProveedores] = telefono;
                direccion_proveedor[contadorProveedores] = direccion;
                ciudad_proveedor[contadorProveedores] = ciudad;
                contadorProveedores++;

                // Limpiar y mostrar mensaje final
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(5, 10);
                Console.Write("Proveedor registrado correctamente!");
                Console.SetCursorPosition(5, 11);
                Console.Write("¿Desea registrar otro proveedor? (s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione Enter para volver al menú principal...");
                    Console.ReadKey();
                }

            } while (opcion == "s");

            return contadorProveedores;
        }

        public static void Registrar()
        {
            for (int y = 5; y < 29; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 101));
            }

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("REGISTRAR VENDEDOR");

            if (total >= 50)
            {
                Console.WriteLine("Error: Límite de 50 vendedores alcanzado");
                return;
            }

            // Código (debe tener exactamente 11 dígitos y no repetido)
            string codigo;
            bool valido;
            do
            {
                Console.SetCursorPosition(5, 8);
                Console.Write("Código (11 dígitos): ");
                codigo = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(codigo))
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Error: El código solo debe contener números");
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (codigo.Length != 11)
                {
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Error: El código debe tener exactamente 11 dígitos");
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                    valido = false;
                    continue;
                }

                // Validar que no exista
                for (int i = 0; i < total; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El código ya existe");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        break;
                    }
                }
            } while (!valido);

            // Nombres (solo letras)
            string nom;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Nombres: ");
                nom = Console.ReadLine();
                valido = SoloLetras(nom);

                if (!valido)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El nombre solo debe contener letras");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                }
            } while (!valido);

            // Apellidos (solo letras)
            string ape;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Apellidos: ");
                ape = Console.ReadLine();
                valido = SoloLetras(ape);

                if (!valido)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El apellido solo debe contener letras");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                }
            } while (!valido);

            // Sueldo (solo números positivos)
            double sueldo;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Sueldo: ");
                string sueldoTexto = Console.ReadLine();
                valido = double.TryParse(sueldoTexto, out sueldo);

                if (!valido || sueldo < 0)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El sueldo debe ser un número ");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                }
            } while (!valido);

            // Teléfono (debe tener exactamente 9 dígitos)
            string tel;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR VENDEDOR");
                Console.SetCursorPosition(5, 7);
                Console.Write("Teléfono (9 dígitos): ");
                tel = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(tel))
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El teléfono solo debe contener números");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (tel.Length != 9)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El teléfono debe tener exactamente 9 dígitos");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                }
            } while (!valido);

            // Guardar
            codigos[total] = codigo;
            nombres[total] = nom;
            apellidos[total] = ape;
            sueldos[total] = sueldo;
            telefonos[total] = tel;
            total++;

            Console.WriteLine("Vendedor registrado!");
        }


        static bool SoloLetras(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;

            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        static bool SoloNumeros(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;

            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }


        public static void ListarProductos(int totalProductos)
        {
            if (totalProductos == 0)
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("Actualmente no hay productos registrados");
                Console.ReadKey();
                return;
            }
            else
            {
                bool codigoProducto = false;

                while (!codigoProducto)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(7, 6);
                    Console.Write("LISTA DE PRODUCTOS");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Ingrese el CODIGO del producto: ");
                    string CodigoProducto = Console.ReadLine();

                    if (CodigoProducto.Length != 11)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("El CODIGO debe tener 11 dígitos");
                        Console.ReadKey();
                        continue;
                    }

                    for (int i = 0; i < codigos_producto.Length; i++)
                    {
                        if (codigos_producto[i] == CodigoProducto)
                        {
                            codigoProducto = true;
                            Console.SetCursorPosition(5, 9);
                            Console.Write($"Codigo del producto {i + 1}: {codigos_producto[i]}");
                            Console.SetCursorPosition(5, 10);
                            Console.Write($"Nombre del producto: {nombres_producto[i]}");
                            Console.SetCursorPosition(5, 11);
                            Console.Write($"Categoria del producto: {categorias_producto[i]}");
                            Console.SetCursorPosition(5, 12);
                            Console.Write($"Stock del producto: {stocks_producto[i]}");
                            Console.SetCursorPosition(5, 13);
                            Console.Write($"Precio del producto: {precios_producto[i]}");
                            Console.SetCursorPosition(5, 14);
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    }
                    if (!codigoProducto)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("Error: No se encontró ningún producto con ese código");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("¿Desea intentar de nuevo? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();

                        if (respuesta != "s")
                        {
                            codigoProducto = false;
                        }
                    }
                }
            }
        }
        public static void ListarClientes(int contadorClientes)
        {

            if (contadorClientes == 0)
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("Actualmente no hay clientes registrados");
                Console.ReadKey();
                return;

            }
            else
            {
                bool DNIValido = false;

                while (!DNIValido)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(7, 6);
                    Console.Write("LISTA DE CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Ingrese el DNI del cliente: ");
                    string DNICliente = Console.ReadLine();

                    if (DNICliente.Length != 8)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("El DNI debe tener 8 dígitos");
                        Console.ReadKey();
                        continue;
                    }

                    for (int i = 0; i < dni_cliente.Length; i++)
                    {
                        if (dni_cliente[i] == DNICliente)
                        {
                            DNIValido = true;
                            Console.SetCursorPosition(5, 9);
                            Console.Write($"Cliente {i + 1}:");
                            Console.SetCursorPosition(5, 10);
                            Console.Write($"DNI: {dni_cliente[i]}");
                            Console.SetCursorPosition(5, 11);
                            Console.Write($"Nombres: {nombre_cliente[i]}");
                            Console.SetCursorPosition(5, 12);
                            Console.Write($"Apellidos: {apellidos_cliente[i]}");
                            Console.SetCursorPosition(5, 13);
                            Console.Write($"Telefono: {telefono_cliente[i]}");
                            Console.SetCursorPosition(5, 14);
                            Console.Write($"Email: {email_cliente[i]}");
                            Console.SetCursorPosition(5, 15);
                            Console.Write($"Dirección: {direccion_cliente[i]}");
                            Console.SetCursorPosition(5, 16);
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    }
                    if (!DNIValido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("Error: No se encontró ningún cliente con ese DNI");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("¿Desea intentar de nuevo? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();

                        if (respuesta != "s")
                        {
                            DNIValido = false;
                        }
                    }
                }
            }
        }

        public static void ListarVendedores(int total)
        {
            if (total == 0)
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("Actualmente no hay clientes registrados");
                Console.ReadKey();
                return;

            }
            else
            {
                bool codigoValido = false;

                while (!codigoValido)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(7, 6);
                    Console.Write("LISTA DE VENDEDORES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Ingrese el código del vendedor: ");
                    string codigoVendedor = Console.ReadLine();

                    if (codigoVendedor.Length != 11)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("El código debe tener 11 dígitos");
                        Console.ReadKey();
                        continue;
                    }

                    for (int i = 0; i < codigos.Length; i++)
                    {
                        if (codigos[i] == codigoVendedor)
                        {
                            codigoValido = true;
                            Console.SetCursorPosition(5, 9);
                            Console.Write($"Vendedor {i + 1}:");
                            Console.SetCursorPosition(5, 10);
                            Console.Write($"Código: {codigos[i]}");
                            Console.SetCursorPosition(5, 11);
                            Console.Write($"Nombres: {nombres[i]}");
                            Console.SetCursorPosition(5, 12);
                            Console.Write($"Apellidos: {apellidos[i]}");
                            Console.SetCursorPosition(5, 13);
                            Console.Write($"Sueldo: ${sueldos[i]}");
                            Console.SetCursorPosition(5, 14);
                            Console.Write($"Teléfono: {telefonos[i]}");
                            Console.SetCursorPosition(5, 15);
                            Console.Write("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    }

                    if (!codigoValido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("Error: No se encontró ningún vendedor con ese código");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("¿Desea intentar de nuevo? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();

                        if (respuesta != "s")
                        {
                            codigoValido = false;
                        }
                    }
                }
            }
        }

        public static void ListarProveedores(int contadorProveedores)
        {
            // Verificar si hay proveedores registrados
            if (contadorProveedores == 0)
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.Write("Actualmente no hay proveedores registrados");
                Console.SetCursorPosition(5, 7);
                Console.Write("Presione Enter para volver al menú...");
                Console.ReadKey();
                return;
            }

            bool continuar = true;
            while (continuar)
            {
                // Limpiar la zona interna
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(7, 6);
                Console.Write("LISTA DE PROVEEDORES");
                Console.SetCursorPosition(5, 7);
                Console.Write("Ingrese el CÓDIGO del proveedor: ");
                string codigoProveedor = Console.ReadLine();

                // Validar que no esté vacío
                if (codigoProveedor.Length == 0)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El código no puede estar vacío");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                    continue;
                }

                // Buscar el proveedor por CÓDIGO
                bool encontrado = false;
                for (int i = 0; i < contadorProveedores; i++)
                {
                    if (codigo_proveedor[i] == codigoProveedor)
                    {
                        encontrado = true;

                        // Limpiar y mostrar información del proveedor
                        for (int y = 5; y < 29; y++)
                        {
                            Console.SetCursorPosition(1, y);
                            Console.Write(new string(' ', 101));
                        }

                        Console.SetCursorPosition(5, 6);
                        Console.Write("INFORMACIÓN DEL PROVEEDOR");
                        Console.SetCursorPosition(5, 8);
                        Console.Write($"Código del proveedor: {codigo_proveedor[i]}");
                        Console.SetCursorPosition(5, 9);
                        Console.Write($"Empresa proveedora: {empresa_proveedor[i]}");
                        Console.SetCursorPosition(5, 10);
                        Console.Write($"RUC (11 dígitos): {ruc_proveedor[i]}");
                        Console.SetCursorPosition(5, 11);
                        Console.Write($"Representante: {representante_proveedor[i]}");
                        Console.SetCursorPosition(5, 12);
                        Console.Write($"Teléfono (9 dígitos): {telefono_proveedor[i]}");
                        Console.SetCursorPosition(5, 13);
                        Console.Write($"Dirección: {direccion_proveedor[i]}");
                        Console.SetCursorPosition(5, 14);
                        Console.Write($"Ciudad: {ciudad_proveedor[i]}");

                        Console.SetCursorPosition(5, 16);
                        Console.Write("¿Desea buscar otro proveedor? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();

                        if (respuesta != "s")
                        {
                            continuar = false;
                        }
                        break;
                    }
                }

                // Si no se encontró el código
                if (!encontrado)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: No se encontró ningún proveedor con ese código");
                    Console.SetCursorPosition(5, 9);
                    Console.Write("¿Desea intentar de nuevo? (s/n): ");
                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta != "s")
                    {
                        continuar = false;
                    }
                }
            }
        }

        public static string LeerInputConEscape(int x, int y, int maxLength)
        {
            string input = "";
            Console.SetCursorPosition(x, y);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Si presiona ESCAPE, retornamos null (señal para cancelar)
                if (key.Key == ConsoleKey.Escape) return null;

                // Si presiona ENTER, terminamos y devolvemos el texto
                if (key.Key == ConsoleKey.Enter) return input;

                // Manejo de Backspace (Borrar)
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (input.Length > 0)
                    {
                        input = input.Substring(0, input.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                // Escribir caracteres normales
                else if (!char.IsControl(key.KeyChar) && input.Length < maxLength)
                {
                    Console.Write(key.KeyChar);
                    input += key.KeyChar;
                }
            }
        }

        public static void Boleta()
        {
            // Limpiar buffer
            while (Console.KeyAvailable) Console.ReadKey(true);

            // Forzar fondo negro antes de limpiar para evitar el color plomo
            Console.BackgroundColor = ConsoleColor.Black;

            // 1. DIBUJAR LA INTERFAZ
            for (int y = 5; y < 29; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 101));
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (int y = 8; y <= 25; y++)
            {
                Console.SetCursorPosition(10, y);
                Console.Write(new string(' ', 85));
            }
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(40, 9); Console.Write("BOLETA DE VENTA");
            Console.SetCursorPosition(12, 11); Console.Write("DNI CLIENTE:");
            Console.SetCursorPosition(55, 11); Console.Write("NRO BOLETA:");
            Console.SetCursorPosition(12, 13); Console.Write("CLIENTE:");

            Console.SetCursorPosition(12, 16); Console.Write("CODIGO");
            Console.SetCursorPosition(25, 16); Console.Write("PRODUCTOS");
            Console.SetCursorPosition(45, 16); Console.Write("CANTIDAD");
            Console.SetCursorPosition(60, 16); Console.Write("PRECIO UNI");
            Console.SetCursorPosition(75, 16); Console.Write("MONTO");

            Console.SetCursorPosition(12, 23); Console.Write("CODIGO VENDEDOR:");
            Console.SetCursorPosition(55, 23); Console.Write("TOTAL");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(35, 26); Console.Write(" GUARDAR ");
            Console.SetCursorPosition(50, 26); Console.Write(" CANCELAR ");
            Console.ResetColor();

            // Dibujar campos vacíos iniciales
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(25, 11); Console.Write(new string(' ', 20)); // DNI
            Console.SetCursorPosition(67, 11); Console.Write(new string(' ', 10)); // Nro Boleta
            Console.SetCursorPosition(25, 13); Console.Write(new string(' ', 40)); // Cliente
            Console.SetCursorPosition(29, 23); Console.Write(new string(' ', 15)); // Vendedor
            Console.SetCursorPosition(62, 23); Console.Write(new string(' ', 15)); // Total
            Console.ResetColor();

            // ----------------------------------------------------
            // LOGICA 1: NRO BOLETA (Con Escape)
            // ----------------------------------------------------
            string nroBoleta;
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(67, 11); Console.Write("          "); // Limpiar visualmente

                // USAMOS LA NUEVA FUNCIÓN
                nroBoleta = LeerInputConEscape(67, 11, 6);
                Console.ResetColor();

                // VERIFICAMOS SI PRESIONÓ ESCAPE
                if (nroBoleta == null) return; // <--- ESTO TE SACA AL MENÚ ANTERIOR

                if (nroBoleta.Length > 6)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 27); Console.Write("Error: Máx 6 dígitos.");
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 27); Console.Write(new string(' ', 50));
                }
            } while (nroBoleta.Length > 6);

            // ----------------------------------------------------
            // LOGICA 2: DNI CLIENTE (Con Escape)
            // ----------------------------------------------------
            string dniBuscado;
            int indexCliente = -1;
            bool clienteEncontrado = false;

            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(25, 11); Console.Write(new string(' ', 20));

                dniBuscado = LeerInputConEscape(25, 11, 8);
                Console.ResetColor();

                if (dniBuscado == null) return; // <--- SALIR SI PRESIONA ESCAPE

                for (int i = 0; i < contadorClientes; i++)
                {
                    if (dni_cliente[i] == dniBuscado)
                    {
                        indexCliente = i;
                        clienteEncontrado = true;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write((nombre_cliente[i] + " " + apellidos_cliente[i]).PadRight(40));
                        Console.ResetColor();
                        break;
                    }
                }
                if (!clienteEncontrado)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 27); Console.Write("Error: DNI no encontrado.");
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 27); Console.Write(new string(' ', 60));
                }
            } while (!clienteEncontrado);

            // ----------------------------------------------------
            // LOGICA 3: PRODUCTO (Con Escape)
            // ----------------------------------------------------
            string nombreProd;
            int indexProd = -1;
            bool prodEncontrado = false;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(25, 18); Console.Write(new string(' ', 15));

                nombreProd = LeerInputConEscape(25, 18, 20);

                if (nombreProd == null) return; // <--- SALIR SI PRESIONA ESCAPE

                for (int i = 0; i < totalProductos; i++)
                {
                    if (nombres_producto[i] != null && nombres_producto[i].ToLower() == nombreProd.ToLower())
                    {
                        indexProd = i;
                        prodEncontrado = true;
                        Console.SetCursorPosition(12, 18); Console.Write(codigos_producto[i]);
                        Console.SetCursorPosition(60, 18); Console.Write(precios_producto[i].ToString("0.00"));
                        break;
                    }
                }
                if (!prodEncontrado)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 27); Console.Write("Error: Producto no existe.");
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 27); Console.Write(new string(' ', 60));
                }
            } while (!prodEncontrado);

            // --- Cantidad ---
            int cantidad = 0;
            bool stockSuficiente = false;
            do
            {
                Console.SetCursorPosition(45, 18); Console.Write("    ");
                string cantTexto = LeerInputConEscape(45, 18, 5);

                if (cantTexto == null) return; // <--- SALIR SI PRESIONA ESCAPE

                if (int.TryParse(cantTexto, out cantidad) && cantidad > 0)
                {
                    if (cantidad <= stocks_producto[indexProd]) stockSuficiente = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(10, 27); Console.Write($"Stock insuficiente ({stocks_producto[indexProd]}).");
                        Console.ReadKey();
                        Console.SetCursorPosition(10, 27); Console.Write(new string(' ', 60));
                    }
                }
            } while (!stockSuficiente);

            // Cálculos
            double totalMonto = cantidad * precios_producto[indexProd];
            Console.SetCursorPosition(75, 18); Console.Write(totalMonto.ToString("0.00"));

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(62, 23); Console.Write((" S/ " + totalMonto.ToString("0.00")).PadRight(15));
            Console.ResetColor();

            // ----------------------------------------------------
            // LOGICA 4: VENDEDOR (Con Escape)
            // ----------------------------------------------------
            string codVendedor;
            bool vendedorEncontrado = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(29, 23); Console.Write(new string(' ', 15));

                codVendedor = LeerInputConEscape(29, 23, 11);
                Console.ResetColor();

                if (codVendedor == null) return; // <--- SALIR SI PRESIONA ESCAPE

                for (int i = 0; i < total; i++)
                {
                    if (codigos[i] == codVendedor)
                    {
                        vendedorEncontrado = true;
                        break;
                    }
                }
                if (!vendedorEncontrado)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 27); Console.Write("Error: Vendedor no existe.");
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 27); Console.Write(new string(' ', 60));
                }
            } while (!vendedorEncontrado);

            // FIN
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10, 27); Console.Write("¡Venta registrada! (Presione tecla)");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
