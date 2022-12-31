using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacluladora.Calculos
{
    public class Divisao
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public double GetResultado()
        {
            if (valor2 == 0)
                throw new Exception("Não é possível realizar divisão por zero.");

            return (this.valor1 / this.valor2);
        }


    }
}
