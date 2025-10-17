namespace Introdução_C_;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine();
        //* Exibe uma mensagem no console
        Console.WriteLine("==== Bem-vindo(a) ao sistema ====");

        // Console.Write();
        //* Exibe uma mensagem no console sem pular linha
        Console.Write("Digite seu nome: ");

        // Console.ReadLine();
        //* Lê uma entrada do usuário
        string nome = Console.ReadLine();

        // Console.Write();
        Console.Write("Digite sua idade: ");

        // int.Parse(Console.ReadLine());
        //* Lê uma entrada do usuário e converte para inteiro
        int idade = int.Parse(Console.ReadLine());

        // IF/ELSE
        if (idade < 18)
        {
            Console.WriteLine($"Olá, {nome}! Você é menor de idade e tem {idade} anos.");
        }
        else
        {
            Console.WriteLine($"Olá, {nome}! Você é maior de idade e tem {idade} anos.");
        }

        bool menu = true;
        // Menu
        while (menu)
        {
            Console.WriteLine("\n\n==== Menu ===="
                              + "\n1. Tabuada"
                              + "\n2. Contagem"
                              + "\n3. Fibonacci"
                              + "\n4. Potenciação"
                              + "\n5. Fatorial"
                              + "\n6. Palíndromo"
                              + "\n7. Consoantes"
                              + "\n8. Binário"
                              + "\n9. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Escolha um número: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Escolha até que número será multiplicado:");
                    int tabuada = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= tabuada; i++)
                    {
                        Console.Write($"{num} * {i} = {num * i}\n");
                    }
                    break;
                case 2:
                    Console.Write("Digite o número inicial: ");
                    int inicio = int.Parse(Console.ReadLine());
                    Console.Write("Digite o número final: ");
                    int fim = int.Parse(Console.ReadLine());
                    for (int i = inicio; i <= fim; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    Console.Write("Digite a quantidade de termos da sequência de Fibonacci: ");
                    int fibonnaci = int.Parse(Console.ReadLine());
                    int a = 0, b = 1, c;
                    Console.WriteLine("Sequência de Fibonacci:");
                    for (int i = 0; i < fibonnaci; i++)
                    {
                        Console.Write(i == fibonnaci - 1 ? $"{a}\n" : $"{a} ");
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    break;
                case 4:
                    Console.Write("Digite a base: ");
                    int baseNum = int.Parse(Console.ReadLine());
                    Console.Write("Digite o exponente: ");
                    int exponenteNum = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado de {baseNum} elevado à {exponenteNum}: {Math.Pow(baseNum, exponenteNum)}");
                    break;
                case 5:
                    Console.Write("Escolha um número para ver seu fatorial: ");
                    int numFatorial = int.Parse(Console.ReadLine());
                    int fatorial = 1;
                    Console.Write($"{numFatorial}! = ");
                    for (int i = numFatorial; i > 0; i--)
                    {
                        fatorial = fatorial * i;
                        Console.Write(i > 1 ? $"{i} * " : $"{i} = {fatorial}");
                    }
                    break;
                case 6:
                    Console.Write("Digite a palavra desejada: ");
                    string palavra = Console.ReadLine().ToLower();
                    char[] letras = palavra.ToCharArray();
                    char[] invertido = new char[letras.Length];
                    for (int i = 0; i < letras.Length; i++)
                    {
                        invertido[i] = letras[letras.Length - 1 - i];
                    }
                    bool palindromo = true;
                    for (int i = 0; i < letras.Length; i++)
                    {
                        if (letras[i] != invertido[i])
                        {
                            palindromo = false;
                            break;
                        }
                    }
                    palavra = char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();
                    Console.Write(palindromo ? $"{palavra} é Palíndromo" : $"{palavra} não é Palíndromo");
                    break;
                case 7:
                    Console.Write("Digite a palavra desejada: ");
                    string palavraConsoante = Console.ReadLine().ToLower();
                    char[] consoante = palavraConsoante.ToCharArray();
                    int total = 0;
                    for (int i = 0; i < consoante.Length; i++)
                    {
                        if (consoante[i] != 'a' && consoante[i] != 'e' && consoante[i] != 'i' && consoante[i] != 'o' && consoante[i] != 'u')
                        {
                            total++;
                        }
                    }
                    palavraConsoante = char.ToUpper(palavraConsoante[0]) + palavraConsoante.Substring(1).ToLower();
                    Console.Write(total != 1 ? $"A palavra {palavraConsoante} tem {total} letras consoantes" : $"A palavra {palavraConsoante} tem {total} letra consoante");
                    break;
                case 8:
                    Console.Write("Escolha um número decimal: ");
                    int decimalNum = int.Parse(Console.ReadLine());
                    List<int> restos = new List<int>();
                    int j = 0;
                    for (int i = decimalNum; i > 0; i /= 2)
                    {
                        int resto = i % 2;
                        restos.Add(resto);
                        j++;
                    }
                    restos.Reverse();
                    string binaryResultado = string.Join("", restos);
                    Console.WriteLine($"{decimalNum} = {binaryResultado}");
                    break;
                case 9:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Comando desconhecido, tente novamente!");
                    break;
            }
        }
    }
}