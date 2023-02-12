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
            Console.WriteLine("Seeccionar en que plazo de cuotas desea pagar su mueble: \n1- 3 Meses \n2- 6 Meses \n3- 12 Meses \n4- 18 Meses \n5- 24 Meses \n6- Al contado");
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
                case 6:TContrato = "Al contado";
                    break;
            }
            
        }
        public String Mostrar()
        {

            return "Tipo de contrato seleccionado:" + TContrato + "" ;
        }
    }
 
}
