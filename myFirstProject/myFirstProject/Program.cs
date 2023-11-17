internal class Program
{
    
    private static void Main(string[] args)
    {
        int cand1 = 0, cand2 = 0, total = 0, branc = 0, voto = 3;
        string candA, candB;

        Console.WriteLine("Digite o nome do Candidato 1: ");
        candA = Console.ReadLine();
        Console.WriteLine("Digite o nome do Candidato 2: ");
        candB = Console.ReadLine();

        while (voto != 0)
        {
            Console.Clear();
            Console.WriteLine("Vote em um dos candidatos:");
            Console.WriteLine("1. " + candA);
            Console.WriteLine("2. " + candB);
            Console.WriteLine("Para brancos ou nulos digite numero aleatorio");    
            Console.WriteLine("0 encerra votação");
            voto = Convert.ToInt32(Console.ReadLine());
            switch (voto)
            {
                case 1: cand1 ++; total++; break;
                case 2: cand2 ++; total++; break;
                case 0: break;
                default: branc ++; total++; break;
            }
        }
        Console.Clear();
        Console.WriteLine("O resultado final foi:");
        Console.WriteLine(candA + ": " + ((cand1*100)/total) + "%");
        Console.WriteLine(candB + ": " + ((cand2*100)/total) + "%");
        Console.WriteLine("Brancos e nulos: "+ ((branc*100)/total) + "%");
        Console.ReadLine();
    }
}