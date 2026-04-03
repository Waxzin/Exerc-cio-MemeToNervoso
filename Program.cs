string fraseResposta;
string fraseMemeToNervoso;

Console.Write("Fala oque voce acha de mim cara? ");
fraseResposta = Console.ReadLine();

fraseMemeToNervoso = $"{fraseMemeToNervoso.Remove(10)}... NÃO PERA. \n to nervoso";

Console.WriteLine(fraseMemeToNervoso);