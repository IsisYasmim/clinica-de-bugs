// Alterado a variável "dia" para int, pois o switch case funciona melhor com tipos inteiros ou strings.
// Utilizado o Convert.ToInt32 para converter a entrada do usuário de string para int.
Console.Write("Digite um número de 1 a 7: ");
int dia = Convert.ToInt32(Console.ReadLine());

//Corrigido a váriavel "dia" no switch case.
//Antes: switch (diaa) { ... }
//Agora:
switch (dia)
{
    case 1:
        Console.WriteLine("Domingo"); //Estava faltando ponto e virgula ";"
        break; //Estáva faltando ponto e virgula ";"
    //Retirado aspas duplas desnecessárias do número.
    //Antes: case "2": { ... }
    //Agora:    
    case 2:
        Console.WriteLine("Segunda-feira");
        break; //Adicionado Break para evitar "fall through"
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido"); //Adicionado ponto e virgula ";"
        break; //adicionado Break para evitar "fall through"
}                                           