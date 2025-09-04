int[,] matriz = new int[3,3]; // Corrigindo a declaração da matriz
int somaTotal = 0; // Adicionando ;
int somaDiagonal = 0;
int[] maiores = new int[3];

for (int i = 0; i < 3; i++) // Corrigindo a condição do loop para evitar estouro de índice.
{
    for (int j = 0; j < 3; j++) // Corrigindo a condição do loop para evitar estouro de índice.
    {
        Console.Write($"Valor [{i},{j}]: ");
        string? input = Console.ReadLine();
        if (input is null) // Verifica se a entrada não é nula antes de tentar usá-la.
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }
        int valor = int.Parse(input);

        matriz[j, i] = valor;
        somaTotal = somaTotal + valor;

        if (i == j)
        {
            somaDiagonal += matriz[i, j]; // Corrigindo o índice para acessar a diagonal principal
        }

        if (valor > maiores[i])
        {
            maiores[i] = valor;
        }
    }
}

Console.WriteLine($"Soma total: {somaTotal}"); // Adicionando $ para interpolação de string
Console.WriteLine("Soma diagonal principal: " + somaDiagonal);

Console.WriteLine("Maiores por linha:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(maiores[i]); // Corrigindo o índice para acessar o array corretamente
}

int[,] transposta = new int[3,3]; // Corrigindo a declaração da matriz transposta

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        transposta[i, j] = matriz[i, j];
    }
}

Console.WriteLine("Matriz transposta:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(transposta[i,j] + " ");
    }
    Console.WriteLine(); // Adicionando ;
}
