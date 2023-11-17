internal class Program
{
    private static int[,] notas = new int[10, 5];
    private static string[] nomes = new string[10], materias = new string[5];

    private static void Main(string[] args)
    {
        
        Menu();
    }

   private static void Menu()
    {
        
        int opcao = 0;

        Console.Clear();
        Console.WriteLine("Seja bem vindo!\n");
        Console.WriteLine("|  1. Cadastrar alunos  |  2. Cadastrar materias  |");
        Console.WriteLine("|  3. Cadastrar notas   |  4. Consultar notas     |");
        Console.Write("Opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            CadastrarAlunos(ref nomes);
        }
        else if (opcao == 2)
        {
            CadastrarMaterias(ref materias);
        }
        else if (opcao == 3)
        {
            CadastrarNotas(ref notas, ref nomes, ref materias);
        }
        else if (opcao == 4)
        {
            ConsultarNotas(ref nomes, ref materias, ref notas);
        }

        Menu();
    }

    //Cadastrar nomes dos alunos
    private static void CadastrarAlunos(ref string[] nomes)
    {
        Console.Clear();
        Console.WriteLine("Cadastro de alunos\n");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i+1}: ");
            nomes[i] = Console.ReadLine();
        }
        Menu();
    }

    //Cadastrar nomes das materias
    private static void CadastrarMaterias(ref string[] materias)
    {
        Console.Clear();
        Console.WriteLine("Cadastro de materias\n");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome da materia {i+1}: ");
            materias[i] = Console.ReadLine();
        }
        Menu();
    }

    //Cadastrar as notas dos alunos
    private static void CadastrarNotas(ref int[,] notas, ref string[] nomes, ref string[] materias)
    {
        Console.Clear();
        Console.WriteLine("Cadastro de notas\n");
        
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Qual a nota de {nomes[i]} na materia {materias[j]}:  ");
                notas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Menu();
    }


    //Consultar notas dos alunos
    private static void ConsultarNotas(ref string[] nomes, ref string[] materias, ref int[,] notas)
    {
        Console.Clear();
        Console.WriteLine("Consulta de notas\n");
        
        for(int i = 0; i < 10; i++)
        {
            Console.Write(nomes[i] + ": ");
            for(int j = 0;j < 5; j++)
            {
                Console.Write("(" + materias[j] + "= " + notas[i,j] + "pts) | ");
            }
            Console.WriteLine("\n");
        }

        Console.ReadKey();
        Menu();
    }
}