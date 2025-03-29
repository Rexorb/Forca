/*
No jogo de Forca uma palavra é mantida secreta e tenta-se adivinhar quais letras compõem a palavra.

Faça um programa que receba a palavra secreta e uma letra. Avalie se a letra existe ou não na palavra secreta.

Exemplos:


--- Forca ---

Qual a palavra secreta? Jabuticaba
Qual a letra? j

A letra "j" existe na palavra secreta => True

--- Forca ---

Qual a palavra secreta? Jabuticaba
Qual a letra? e

A letra "e" existe na palavra secreta => False
*/


String palavraSecreta = "Otorrinolaringologista";

Console.WriteLine("Digite uma letra: ");
char letra = Convert.ToChar(Console.Read());
Console.ReadLine();


Console.WriteLine(
   palavraSecreta.Contains(letra, StringComparison.OrdinalIgnoreCase)
   ? $"\nA letra '{letra}' existe na palavra \"{palavraSecreta}\"."
   : $"\nA letra '{letra}' NÃO existe na palavra \"{palavraSecreta}\"."
);



