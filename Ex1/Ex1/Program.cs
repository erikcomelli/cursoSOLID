// See https://aka.ms/new-console-template for more information
using Ex1;

var cliente = LocalizaCliente.ProcuraPorNome("Pedro");
// ?. verifica se o operando esquerdo for null não avalia
// os demais operandos e não lança NullReferenceException
//--------------------------------------------------------
// ?? retorna o valor do operando esquerdo se não for null
// se for null avalia o operando direito e retorna o seu valor
Console.WriteLine(cliente?.Nome ?? "Não localizado");
Console.ReadLine();
