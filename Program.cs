using System.Linq.Expressions;

int opcao;

Console.WriteLine("Escolha uma opção.");

Console.WriteLine("1 - Reverta a ordem das palavras nas frases, mantendo a ordem das palavras.");
Console.WriteLine("2 - Remova todos os caracteres duplicados da string abaixo.");
Console.WriteLine("3 - Encontre a substring palindroma mais longa na string abaixo.");
Console.WriteLine("4 - Coloque em maiúcula a primeira letra de cada frase de string.");
Console.WriteLine("5 - Verifique se a string é um anagrama de um palindromo.");


Console.WriteLine("Digite sua opção:");
opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        reverterOrdem();
        break;

        case 2:
        removerDuplicados();
        break;
}

void reverterOrdem()
{
    string frase;
    string fraseInvertida;
    

    Console.WriteLine("Digite uma frase:");
    frase = Console.ReadLine();
    string[] palavras = frase.Split(" ");
    fraseInvertida = string.Join(" ", palavras.Reverse());

    Console.WriteLine($"Frase Convertida: {fraseInvertida}");
}