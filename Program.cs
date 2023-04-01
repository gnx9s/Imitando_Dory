string frase;
string frase_em_baleiês;


Console.WriteLine("Escreva uma frase a ser traduzida: ");
frase = Console.ReadLine()!;

frase_em_baleiês = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
;
            
Console.WriteLine($"Em baleiês: {frase_em_baleiês}");