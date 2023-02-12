using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase
{
    internal class Empleados:Inmuebles
    {
        

        public void Empleadoos(string _nombreEmpleado)
        {
           
            
            
            Console.WriteLine("Bienvenido un gusto atenderle, seleccione el empleado que desee que lo atienda:\n1-Manuel\n2-Jordy\n3-Daniel\n4-Andy\n5-Marvin\n");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Nombre = "Manuel";
                    Apellido = "Castro";

                    
                    break;
                case 2:
                    Nombre = "Jordy";
                    Apellido = "Cortez";
                    
                    break;
                case 3:
                    Nombre = "Daniel";
                    Apellido = "Tejada";
                    break;
                case 4:
                    Nombre = "Andy";
                    Apellido = "Moran";
                    break;
                case 5:
                    Nombre = "Marvin";
                    Apellido = "Rivas";
                    break;
            }

        }
        public String Empleado()
        {

            return "El empleado que lo atendio:" + Nombre + " " + Apellido;
        }

    }
}
