//Console.WriteLine() sem ponto e virgula ";"
//Adicionado um ponto e virgula no final da linha
//Adiocionado o operador de coalescência nula "??" para evitar erro de conversão
Console.WriteLine("Por favor, digite seu primeiro nome: ");
string? primeiroNome = Console.ReadLine();

//Utilizado o Convert.ToInt32 para converter a string em inteiro
Console.WriteLine("Agora, digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

//Alterado exemplo de entrada de altura para o formato correto de "," para "."
//Adicionado o operador de coalescência nula "??" para evitar erro de conversão, e utilizado 0 como valor padrão
Console.WriteLine("Por fim, digite sua altura em metros (ex: 1.80)");
float altura = float.Parse(Console.ReadLine() ?? "0");

//Corrigito o nome da variável "PrimeiroNome" para "primeiroNome".
Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura}m.");
