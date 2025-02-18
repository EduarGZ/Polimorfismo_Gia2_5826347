using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Gia2_5826347
{
    internal class Promedio
    {
        //Atributos
        public string estudiante { get; set; }
        public int evaluacion1 {  get; set; }
        public int evaluacion2 { get; set; }
        public int evaluacion3 { get; set; }
        public int actitudinal { get; set; }

        //Método para determinar la condicion del estudiante
        public virtual double calculaPromedio()
        {
            return (evaluacion1 + evaluacion2 + evaluacion3 + actitudinal) / 4;
        }
        //Método para determinar la condicion del estudiante
        public string determinaCondicion()
        {
            if(calculaPromedio() < 12.5)
            {
                return "Desaprobado";
            }
            else
            {
                return "Aprobado";
            }
        }
    }
}
