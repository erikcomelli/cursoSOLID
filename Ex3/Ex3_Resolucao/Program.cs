using Ex3_Resolucao;

ICalcularImpostoPais calculoBrasil = new CalcularImpostoBrasil();
calculoBrasil.TotalDeducao = 100;
calculoBrasil.TotalRenda = 1000;

CalcularImposto calculo = new CalcularImposto(calculoBrasil);
var valorTotal = calculo.Calcular();
Console.WriteLine($"Brasil {valorTotal}");

Console.ReadLine();