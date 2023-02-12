using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase
{
    internal class tipoDePago
    {
        private string tContrato;

        public string TContrato { get => tContrato; set => tContrato = value; }

        public void Contrato(string _Contrato)
        {
            this.TContrato = _Contrato;
            Console.WriteLine("Ingrese el tipo de contrato que desea: \n1- 3 Meses \n2- 6 Meses \n3- 12 Meses \n4- 18 Meses \n5- 24 Meses");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    TContrato = "3 Meses";
                    break;
                case 2:
                    TContrato = "6 Meses";
                    
                    break;
                case 3:
                    TContrato = "12 Meses";
                    
                    break;
                case 4:
                    TContrato = "18 Meses";
                    
                    break;
                case 5:
                    TContrato = "24 Meses";
                    
                    break;
            }
            
        }
        public String Mostrar()
        {

            return "Tipo de contrato seleccionado:" + TContrato + "" ;
        }
    }
 
}
