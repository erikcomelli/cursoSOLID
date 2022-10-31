using Ex2_Resolucao;

ILogger logArquivo = new FileLogger();
ILogger logConsole = new ConsoleLogger();

Pedido pedido = new Pedido(logArquivo);
pedido.AdicionarPedido();

Console.ReadLine();