using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Gia2_5826347
{
    internal class PromedioProgramacion: Promedio
    {
        //Métodos para calcular el promedio de programación
        public override double calculaPromedio()
        {
            return evaluacion1 * 0.15 + evaluacion2 * 0.3 + evaluacion3 * 0.5 + actitudinal * 0.05;
        }
    }
}
