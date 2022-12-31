using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cacluladora.Calculos
{
    public class Calculadora
    {
        public string sinal { get; set; }
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public double GetResultado()
        {
            double resultado;

            switch (sinal)
            {
                case "-":
                    Subtracao sub = new Subtracao();
                    sub.valor1 = valor1;
                    sub.valor2 = valor2;
                    resultado = sub.GetResultado();
                    break;
                case "+":
                    Adicao adi = new Adicao();
                    adi.valor1 = valor1;
                    adi.valor2 = valor2;
                    resultado = adi.GetResultado();
                    break;
                case "*":
                    Multiplicacao mul = new Multiplicacao();
                    mul.valor1 = valor1;
                    mul.valor2 = valor2;
                    resultado = mul.GetResultado();
                    break;
                case "/":
                    Divisao div = new Divisao();
                    div.valor1 = valor1;
                    div.valor2 = valor2;
                    resultado = div.GetResultado();
                    break;
                default:
                    throw new Exception("Sinal informado é invalido!");
                    break;
            }

            return resultado;
        }

    }
}
