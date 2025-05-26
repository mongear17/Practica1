using ControlDePagos;
using System;
using System.Collections.Generic;

bool opcionMenu = true;
List<Cliente> clientes = new List<Cliente>();

while (opcionMenu)
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
            Console.Write("Ingrese la cédula del cliente: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el teléfono del cliente: ");
            string telefono = Console.ReadLine();
            Cliente nuevoCliente = new Cliente(cedula, nombre, telefono);
            clientes.Add(nuevoCliente);
            Console.WriteLine("Cliente creado con éxito.\n");
            break;

        case "2":
            Console.Write("Ingrese la cédula del cliente a consultar: ");
            string cedulaConsulta = Console.ReadLine();
            Cliente clienteConsulta = clientes.Find(c => c.Cedula == cedulaConsulta);
            if (clienteConsulta != null)
            {
                Console.WriteLine(clienteConsulta.VerDeuda() + "\n");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.\n");
            }
            break;

        case "3":
            Console.WriteLine("Lista de clientes:");
            foreach (Cliente c in clientes)
            {
                Console.WriteLine("- " + c.Nombre);
            }
            Console.WriteLine();
            break;

        case "4":
            Console.Write("Ingrese la cédula del cliente a abonar: ");
            string cedulaAbono = Console.ReadLine();
            Cliente clienteAbono = clientes.Find(c => c.Cedula == cedulaAbono);
            if (clienteAbono != null)
            {
                Console.Write("Ingrese el monto a abonar: ");
                if (double.TryParse(Console.ReadLine(), out double montoAbono))
                {
                    clienteAbono.AbonarDeuda(montoAbono);
                    Console.WriteLine("Abono realizado.\n");
                }
                else
                {
                    Console.WriteLine("Monto inválido.\n");
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.\n");
            }
            break;

        case "5":
            Console.WriteLine("Saliendo del sistema.");
            opcionMenu = false;
            break;

        default:
            Console.WriteLine("Seleccione una opción del 1 al 5.\n");
            break;
    }
}
