double total = 0; // Valores atribuídos a esta variável devem ser do tipo double.
while (total < 50)
{
    Console.Write("Digite o valor a ser guardado: ");
    string? input = Console.ReadLine();
    
    if (input is not null) // Verifica se a entrada não é nula antes de tentar usá-la.
    {
        double valor = double.Parse(input.Replace('.', ','));
        total += valor; // Adiciona o valor digitado ao total, e não o substitui.
    }
}
Console.WriteLine($"Meta atingida! Total economizado: R$ {total}"); // Deve-se utilizar o símbolo $ para interpolação de strings.