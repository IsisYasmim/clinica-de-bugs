int[] notas = new int[5];

for (int i = 0; i < notas.Length; i++) // O loop deve iterar até o tamanho do array.
{
    Console.Write($"Digite a nota {i + 1}: ");
    string? input = Console.ReadLine(); 
    if (input is null) // Verifica se a entrada não é nula antes de tentar usá-la.
    {
        Console.WriteLine("Entrada inválida.");
        return;
    }
    notas[i] = int.Parse(input);
}

for (int i = 0; i < notas.Length; i++)
{
    string situacao = notas[i] >= 7 ? "Aprovado": "Reprovado"; // Corrigido o operador ternário para refletir a lógica correta.
    Console.WriteLine($"Nota (i + 1): {notas[i]} - {situacao}");
}