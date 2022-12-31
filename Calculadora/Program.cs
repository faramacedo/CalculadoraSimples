using Cacluladora.Calculos;

Calculadora calc = new Calculadora();


Console.WriteLine("Bem-vindo a calculadora");
Console.WriteLine("Digite a operação que deseja realizar");
Console.WriteLine("\n(+)Soma\n(-)Subtração\n(*)Multiplicacao\n(/)Divisão");

calc.sinal = Console.ReadLine();

if (calc.sinal =="/")
    Console.WriteLine("Para divisão o valor1 é o dividendo e o valor2 é o divisor.");

Console.WriteLine("Digite o valor1:");
calc.valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor2:");
calc.valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O resultado é {calc.GetResultado()}");