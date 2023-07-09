using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;

int opcao;

Console.WriteLine("Escolha uma opção.");

Console.WriteLine("1 - Reverta a ordem das palavras nas frases, mantendo a ordem das palavras.");
Console.WriteLine("2 - Remova todos os caracteres duplicados da string abaixo.");
Console.WriteLine("3 - Encontre a substring palindroma mais longa na string abaixo.");
Console.WriteLine("4 - Coloque em maiúcula a primeira letra de cada frase na string.");
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

    case 3:
        maiorPolindromo();
        break;

        case 4:
        colocarMaiusculo();
        break;

        case 5:
        verifarAnagramaPolindromo();
        break;  
}

void reverterOrdem()
{
    Console.Clear();
    string frase;
    string fraseInvertida;
    

    Console.WriteLine("Digite uma frase:");
    frase = Console.ReadLine();
    string[] palavras = frase.Split(" ");
    fraseInvertida = string.Join(" ", palavras.Reverse());

    Console.WriteLine($"Frase Convertida: {fraseInvertida}");
}

void removerDuplicados()
{
    Console.Clear();
    string frase;
    string fraseRemovida;

    Console.WriteLine("Digite uma frase:");
    frase = Console.ReadLine();
    fraseRemovida = removerCaracteresDuplicados(frase);
    Console.WriteLine($"Frase Convertida: {fraseRemovida}");
}

static string removerCaracteresDuplicados(string texto)
{
    // Armazena as letras 
    string letras = "";
    // armazena o resultado
    string resultado = "";
    // Percorre cada caractere do texto
    foreach (char valor in texto)
    {
        // Verifica se o caractere esta na tabela
        if (letras.IndexOf(valor) == -1)
        {
            // anexa as letras na tabela e no resultado
            letras += valor;
            resultado += valor;
        }
    }
    return resultado;
}

void maiorPolindromo()
{
    Console.Clear();
    string palavra;
    
    Console.WriteLine("Digite uma palavra:");
    palavra = Console.ReadLine();

    string maiorPolindromo = verificarMaiorPolindromo(palavra);
    Console.WriteLine("A substring palíndroma mais longa é: " + maiorPolindromo);
}

static string verificarMaiorPolindromo(string str)
{
    int maiorTamanho = 1;
    int inicio = 0;
    int tamanhoString = str.Length;

    int menor, maior;

    // Percorre a string e verifica cada caractere como centro da substring palíndroma
    for (int i = 1; i < tamanhoString; ++i)
    {
    // Encontra a substring palíndroma de tamanho ímpar
        menor = i - 1;
        maior = i + 1;
        while (menor >= 0 && maior < tamanhoString && str[menor] == str[maior])
        {
            if (maior - menor + 1 > maiorTamanho)
            {
                inicio = menor;
                maiorTamanho = maior - menor + 1;
            }
            --menor;
            ++maior;
        }

        // Encontra a substring palíndroma de tamanho par
        menor = i - 1;
        maior = i;
        while (menor >= 0 && maior < tamanhoString && str[menor] == str[maior])
        {
            if (maior - menor + 1 > maiorTamanho)
            {
                inicio = menor;
                maiorTamanho = maior - menor + 1;
            }
            --menor;
            ++maior;
        }
    }

    return str.Substring(inicio, maiorTamanho);
}
void verifarAnagramaPolindromo()
{
    Console.Clear();
    string palavra, anagrama = "";
    Console.WriteLine("Digite a palavra: ");
    palavra = Console.ReadLine();

    for (int i = palavra.Length - 1; i >= 0; i--) //Palara invertida 
    {
        anagrama += palavra[i].ToString();
    }
    if (anagrama == palavra) // Validando se a string é um polindromo ou não.  
    {
        Console.WriteLine("True.");
    }
    else
    {
        Console.WriteLine("False.");
    }
       Console.ReadKey();
}
void colocarMaiusculo()
{
    string frase;
    Console.WriteLine("Digite uma frase:");
    frase = Console.ReadLine();

    string output = maiusculoPrimeiraLetra(frase);

    Console.WriteLine(output);
}

    static string maiusculoPrimeiraLetra(string input)
    {
        char[] caracterFrase = input.ToCharArray();

        // Define os delimitadores de frase
        char[] delimitadorFrase = { '.', '?', '!' };

        caracterFrase[0] = char.ToUpper(caracterFrase[0]);

    // Percorre o array de caracteres
    for (int i = 0; i < caracterFrase.Length; i++)
    {
        // Verifica se o caractere atual é um delimitador de frase
        if (Array.IndexOf(delimitadorFrase, caracterFrase[i]) != -1 && i< (caracterFrase.Length-1))
        {
           
            caracterFrase[i + 2] = char.ToUpper(caracterFrase[i + 2]);
           
        }

        
    }
    // Retorna a string modificada
    return new string(caracterFrase);
    }


