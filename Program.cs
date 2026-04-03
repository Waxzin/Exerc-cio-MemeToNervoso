string fraseResposta, memeToNervoso = "Seu filha de uma";

Console.Write("Fala oque voce acha de mim?");
fraseResposta = Console.ReadLine()!;

 memeToNervoso = 
    $"{memeToNervoso.Remove(10)}... NÃO PERA. \n to Nervoso"!;

Console.WriteLine(memeToNervoso);