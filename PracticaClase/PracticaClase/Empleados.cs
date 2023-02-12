using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase
{
    internal class Empleados:Inmuebles
    {
        private string NombreEmpleado;

        public string NombreEmpleado1 { get => NombreEmpleado; set => NombreEmpleado = value; }

        public void Empleadoos(string _nombreEmpleado)
        {
            this.NombreEmpleado = _nombreEmpleado;
            
            
            Console.WriteLine("Bienvenido un gusto atenderle, seleccione el empleado que desee que lo atiemda:\n1-Manuel\n2-Jordy\n3-Daniel\n4-Andy\n5-Marvin\n");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Nombre = "Manuel";
                    
                    break;
                case 2:
                    Nombre = "Jordy";
                    
                    break;
                case 3:
                    Nombre = "Daniel";
                    
                    break;
                case 4:
                    Nombre = "Andy";
                   
                    break;
                case 5:
                    Nombre = "Marvin";
                    
                    break;
            }

        }
        public String Empleado()
        {

            return "El empleado que lo atendio:" + Nombre + "";
        }

    }
}
