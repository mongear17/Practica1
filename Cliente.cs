using System;

namespace ControlDePagos
{
    // Clase que representa a un cliente
    public class Cliente
    {
        // Propiedades
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public double MontoDeuda { get; set; }

        // Constructor
        public Cliente(string cedula, string nombre, string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
            MontoDeuda = 0;
        }

        // Método para abonar a la deuda
        public void AbonarDeuda(double monto)
        {
            if (MontoDeuda <= 0)
            {
                Console.WriteLine("Este cliente no tiene deuda.");
                return;
            }

            if (monto > 0)
            {
                if (monto > MontoDeuda)
                {
                    Console.WriteLine("El monto a abonar excede la deuda. Se abonará solo lo necesario.");
                    MontoDeuda = 0;
                }
                else
                {
                    MontoDeuda -= monto;
                }
            }
            else
            {
                Console.WriteLine("El monto a abonar debe ser mayor que cero.");
            }
        }

        // Método para ver la deuda del cliente
        public string VerDeuda()
        {
            return "El cliente " + Nombre + " tiene una deuda de " + MontoDeuda.ToString("C") + ".";
        }
    }
}
