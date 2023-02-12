using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase
{
    internal class Inmuebles:Clientes
    {
        private string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        public void TipoMueble(string _Tipo)

        {

            this.Tipo = _Tipo;
            Empleados empleado = new Empleados();
            Console.WriteLine("Ingrese el tipo de mueble que desea: \n1-Sofas \n2-Mesas \n3-Sillas \n 4-Camas \n5-Televisores");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Tipo = "Sofas";
                    
                    break;
                case 2:
                    Tipo = "Mesas";
                 
                    break;
                case 3:
                    Tipo = "Sillas";
                    
                    break;
                case 4:
                    Tipo = "Camas";
                   
                    break;
                case 5:
                    Tipo = "Televisores";
                    
                    break;
            }
        }
        public String Mirar()
        {

            return "Mueble seleccionado:" + Tipo + "";
        }
    }
    
    
}
