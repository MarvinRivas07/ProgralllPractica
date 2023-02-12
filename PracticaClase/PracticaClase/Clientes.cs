using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaClase
{
    internal class Clientes:tipoDePago
    {
        public string Nombre;
        public string Apellido;
        public int DUI;


        public void Comprar()
        {
            try
            {
                Console.WriteLine("Ingrese sus datos personales:");
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese su nombre");
                Nombre = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su apellido");
                Apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su DUI");
                DUI = int.Parse(Console.ReadLine()); 
                
                               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);
            }
        }
        public String Ver()
        {

            return "Nombre de cliente:" + Nombre + "   " + "Apellido: " + Apellido + "  " + "Numero de DUI:" + DUI;
        }

    }
}
