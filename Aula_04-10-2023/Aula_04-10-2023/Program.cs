using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        int sorte, chance;
        Random numAleatorio = new Random();
        int numero = numAleatorio.Next(1, 100);

        Console.WriteLine("Jogo da sorte\n");
        for (chance = 1; chance <= 4; chance++)
        {
            Console.WriteLine("Tenta a sorte (4 tentativas): ");
            sorte = int.Parse(Console.ReadLine());  

            if (numero == sorte)
            {
                Console.WriteLine("Você acertou !!!");
                chance = 5;
            }
            else if (numero < sorte)
            {
                Console.Clear();
                Console.WriteLine("O número é menor!" + "  " + chance + " Tentativas");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O número é maior!" + "  " + chance + " Tentativas");
            }
        }
        Console.WriteLine("O número é " + numero);
    }
}