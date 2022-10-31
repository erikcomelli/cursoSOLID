using Ex1_Resolucao;

var cliente = LocalizaCliente.ProcuraPorNome("Pedro");

Console.WriteLine(cliente?.Nome ?? "Não localizado");
Console.ReadLine();
