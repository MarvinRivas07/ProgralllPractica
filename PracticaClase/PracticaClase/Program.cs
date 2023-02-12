using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase
{
    internal class Program:Empleados
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido \n");

            Console.WriteLine("Opciones\n 1- Comprar \n 2-Salir");
            int opcion = int.Parse(Console.ReadLine()); 

            switch (opcion)
            {
                case 1:
                    Clientes cliente = new Clientes();
                    cliente.Comprar();
                    Empleados emp = new Empleados();
                    emp.Empleadoos(emp.Nombre);
                    tipoDePago contrato = new tipoDePago();
                    Inmuebles inmuebles = new Inmuebles();
                    inmuebles.TipoMueble(inmuebles.Tipo);
                    contrato.Contrato(contrato.TContrato);
                    Console.WriteLine(cliente.Ver());
                    Console.WriteLine(emp.Empleado());
                    Console.WriteLine(inmuebles.Mirar());
                    Console.WriteLine(contrato.Mostrar());




                    break;
                default:
                    Console.WriteLine("Lo siento");
                    break;
            }
        }

        
    }
 
}