string resposta;
do
{
    //Utilizado habitação "??" com "" para evitar erro de referência nula
    //Utilizado ToUpper() para evitar erro de digitação
    Console.Write("Deseja sair? (S/N): ");
    resposta = (Console.ReadLine() ?? "").ToUpper();
}
//Corrigido o operador lógico de "||" para "&&"
//Alterado teste para aceitar apenas "S" como resposta para sair do loop
while (resposta != "S");
//Corrigido o método WriteLine
//Antes: Cpmsole.writeLine();
//Agora
Console.WriteLine("Programa encerrado."); 