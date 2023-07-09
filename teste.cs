using System;

class teste
{
    static string LongestPalindromeSubstring(string str)
    {
        int maxLength = 1;
        int start = 0;
        int length = str.Length;

        int low, high;

        // Percorre a string e verifica cada caractere como centro da substring palíndroma
        for (int i = 1; i < length; ++i)
        {
            // Encontra a substring palíndroma de tamanho ímpar
            low = i - 1;
            high = i + 1;
            while (low >= 0 && high < length && str[low] == str[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                --low;
                ++high;
            }

            // Encontra a substring palíndroma de tamanho par
            low = i - 1;
            high = i;
            while (low >= 0 && high < length && str[low] == str[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                --low;
                ++high;
            }
        }

        return str.Substring(start, maxLength);
    }

    static void Main()
    {
        string input = "bananana";
        string longestPalindrome = LongestPalindromeSubstring(input);
        Console.WriteLine("A substring palíndroma mais longa é: " + longestPalindrome);
    }
}
