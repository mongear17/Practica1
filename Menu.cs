using System;
using System.Collections.Generic;

namespace ControlDePagos
{
    public class Menu
    {
        private List<Cliente> _clientes;

        public Menu(List<Cliente> clientes)
        {
            _clientes = clientes;
        }

        // Método para mostrar el menú principal
        public void MostrarMenu()
        {
            bool opcionMenu = true;
            while (opcionMenu)
            {
                try
                {
                    Console.WriteLine("**** Menu de control de clientes ****");
                    Console.WriteLine("1 - Crear cliente");
                    Console.WriteLine("2 - Consultar deuda cliente");
                    Console.WriteLine("3 - Ver todos los clientes");
                    Console.WriteLine("4 - Abonar deuda");
                    Console.WriteLine("5 - Salir");
                    Console.Write("Seleccione una opcion: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            _clientes.Add(AgregarUsuario());
                            break;

                        case "2":
                            Console.WriteLine("Funcionalidad no implementada aún.");
                            break;

                        case "3":
                            Console.WriteLine("Funcionalidad no implementada aún.");
                            break;

                        case "4":
                            Console.WriteLine("Funcionalidad no implementada aún.");
                            break;

                        case "5":
                            opcionMenu = false;
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al mostrar el menu: " + ex.Message);
                }
            }
        }

        // Método para agregar un nuevo cliente
        public Cliente AgregarUsuario()
        {
            Cliente cliente = null;
            try
            {
                Console.WriteLine("Creando Cliente");
                Console.Write("Ingrese la cédula del cliente: ");
                string cedula = Console.ReadLine();
                Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el teléfono del cliente: ");
                string telefono = Console.ReadLine();
                cliente = new Cliente(cedula, nombre, telefono);
                Console.WriteLine("Cliente creado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                // Si ocurre error, devolvemos un cliente vacío para evitar problemas
                cliente = new Cliente("N/A", "Error", "N/A");
            }
            return cliente;
        }
    }
}
