Console.Write("Digite um número para ver a tabuada: ");

string? input = Console.ReadLine(); // Verifica se a entrada não é nula antes de tentar usá-la.

if (input is null)
{
    Console.WriteLine("Entrada inválida.");
    return;
}

int num = int.Parse(input);

for (int i = 1; i <= 10; i++) // Iteração deve ir até 10, adicionando em vez de subtraindo.
{
    Console.WriteLine($"{num} x {i} = {num * i}"); // A variável j não existe.
}