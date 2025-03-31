
String nome,sobrenome;

Console.Write("Digite Seu Nome: ");
nome = Console.ReadLine();

Console.Write("Digite Seu Sobrenome:  ");
sobrenome = Console.ReadLine();

Console.WriteLine("Nome Completo: " + nome + " " + sobrenome);
Console.WriteLine("Nome de Catálogo: " + sobrenome.ToUpper() + ", " + nome);


