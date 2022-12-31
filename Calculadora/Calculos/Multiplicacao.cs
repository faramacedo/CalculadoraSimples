using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacluladora.Calculos
{
    public class Multiplicacao
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public double GetResultado()
        {
               return (this.valor1 * this.valor2);
        }


    }
}
