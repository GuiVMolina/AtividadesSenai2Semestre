namespace C_;

class Program
{
    static unsafe void Main()
    {
        // Declaração de uma variável inteira
        int variávelX = 10;
        Console.WriteLine($"Variável X: {variávelX}");

        // Obtendo o endereço de memória da variável usando ponteiros
        int* ponteiroA = &variávelX;
        Console.WriteLine($"Endereço de memória da variável X: {(ulong)ponteiroA}");

        // Modificando o valor da variável através do ponteiro
        *ponteiroA = 75;
        Console.WriteLine($"Variável X: {variávelX}");

        int[] numeros = { 10, 20, 30, 40 };

        fixed (int* ponteiroArray = numeros)
        {
            Console.WriteLine($"Endereço do Array: {(ulong)ponteiroArray}");
            Console.WriteLine($"ponteiroArray[0] = {*(ponteiroArray + 0)}");
            Console.WriteLine($"ponteiroArray[1] = {*(ponteiroArray + 1)}");
            Console.WriteLine($"ponteiroArray[2] = {*(ponteiroArray + 2)}");
            Console.WriteLine($"ponteiroArray[3] = {*(ponteiroArray + 3)}");
            Console.WriteLine($"ponteiroArray[?] = {*(ponteiroArray + 4)}");
        }
    }
}