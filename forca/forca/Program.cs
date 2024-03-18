internal class Program
{
    private static void Main(string[] args)
    {
        string palavra, letra = "";
        int tentativas = 1, falta = 2;
        segredo[] segredo = new segredo[50];

        Console.WriteLine("Jogo da forca\n");
        Console.Write("Digite a palavra segredo: ");
        palavra = Console.ReadLine();

        for (int i = 0; i < palavra.Length; i++)
        {
            segredo[i].dividido = palavra.Substring(i, 1);
        }

        while (falta > 0 && tentativas <= 10)
        {
            falta = 0;

            if (palavra.Contains(letra))
            {
                for (int i = 0; i < palavra.Length; i++)
                    if (segredo[i].dividido == letra)
                    {
                        segredo[i].corretos = segredo[i].dividido;
                    }
            }
            else
            {
                tentativas++;
            }

            Console.Clear();
            Console.WriteLine($"Advinhe a palavra - tentativa: {tentativas} de 10\n");

            for (int i = 0; i < palavra.Length; i++)
            {
                if (segredo[i].corretos == "" || segredo[i].corretos == null)
                {
                    Console.Write("_");
                    falta++;
                }
                else
                {
                    Console.Write(segredo[i].corretos);
                }
            }

            Console.Write($"  -  {palavra.Length} letras");
            if (falta > 0 && tentativas <= 10)
            {
                Console.Write("\n\nDigite uma letra: ");
                letra = Console.ReadLine();
            }

            if (letra.Length > 1 || letra.Length < 1)
            {
                Console.Write("Digite apenas uma letra");
                letra = "";
                Console.ReadKey();
            }
        }

        Console.Clear();
        if (tentativas <= 10)
        {
            Console.WriteLine("Acertou a Palavra");
            Console.WriteLine(palavra);
            Console.WriteLine("Parabens!!!");
        }
        else
        {
            Console.WriteLine("Infelizmente voce perdeu");
            Console.WriteLine($"A palavra correta era: {palavra}");
        }
        Console.ReadKey();
    }

    struct segredo
    {
        public string dividido;
        public string corretos;
    }
}