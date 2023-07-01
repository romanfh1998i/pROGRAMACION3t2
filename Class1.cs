using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public  class ClassUapa
    {
        public double Examen { get; set; }
        public double plataforma { get;set; }
        public double Actitudes { get; set; }
        public double TrabajoFinal { get; set; }
        public double calcularNota(double Examen,double platarforma,double Actitudes,double TrabajoFinal)
        {
            double calcularNota = Examen + platarforma + Actitudes + TrabajoFinal;
            return calcularNota;
        }
        public bool calcularResultado(int  calularNota)
        {
            if (calularNota < 0)
            {
                Console.WriteLine("Su califacion no es valida");
                return false;

            }
            else if (calularNota <= 70)
            {
                Console.WriteLine("Esta reprobado");
                return false;
            }

            if  (calularNota >= 70){
                Console.WriteLine("Aprovo la materia");
                return true;





            }
            
        }
       
    }
}
