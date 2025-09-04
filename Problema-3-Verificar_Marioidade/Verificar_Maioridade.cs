Console.Write("Digite sua idade: ");
//Utilizado o Convert.ToInt32 para converter a entrada do usuário de string para inteiro.
int idade = Convert.ToInt32(Console.ReadLine());

//Alterado o operador lógico para o padrão correto de comparação.
//Antes: if (idade => 18)
//Agora:
if (idade >= 18) //Retirado o ponto e vírgula erroneamente colocado.
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}