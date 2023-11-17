using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[10];
        int posic = 0;

        Menu(ref pessoas, ref posic);
    }

    private static void Menu(ref Pessoa[] pessoas, ref int posic)
    {
        int opcao = 0;
        Console.Clear();
        Console.WriteLine("Menu inicial\n");
        Console.WriteLine("|  1. Cadastrar pessoas  |  2. Consultar pessoas  |");
        Console.Write("Opção: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
        }
        catch { }

        switch (opcao)
        {
            case 1:
                CadastroPessoas(ref pessoas, ref posic);
                break;
            case 2:
                ConsultaPessoas(ref pessoas, ref posic);
                break;
            default:
                Console.Write("Opção inválida!");
                Console.ReadKey();
                Menu(ref pessoas, ref posic);
                break;
        }
    }

    struct Pessoa
    {
        public int Id;
        public string Name;
        public int CpfId;
    }

    //Cadastra pessoas na estrutura de dados Pessoa
    private static void CadastroPessoas(ref Pessoa[] pessoas, ref int posic)
    {
        string continuar;
        pessoas[posic].Id = posic + 1;
        Console.Clear();
        Console.WriteLine("Cadastro de pessoas\n");
        Console.Write("Digite o nome da pessoa a ser cadastrada: ");
        pessoas[posic].Name = Console.ReadLine();
        Console.Write("Digite o cpf da pessoa: ");
        try
        {
            pessoas[posic].CpfId = Convert.ToInt32(Console.ReadLine());
            posic++;
        }
        catch
        {
            Console.Write("CPF inválido!");
            Console.ReadKey();
            CadastroPessoas(ref pessoas, ref posic);
        }

        Console.Write("Cadastrar outra pessoa  (s/n)? ");
        continuar = Console.ReadLine();

        if(continuar == "s")
        {
            CadastroPessoas(ref pessoas, ref posic);
        }

        Menu(ref pessoas, ref posic);
    }

    //Consulta pessoas cadastradas na estrutura de dados Pessoa
    private static void ConsultaPessoas(ref Pessoa[] pessoas, ref int posic)
    {
        Console.Clear();
        Console.WriteLine("Consulta de pessoas\n");

        for (int i = 0; i < 10; i++)
        {
            if (pessoas[i].CpfId > 0)
            {
                Console.WriteLine($"Id: {pessoas[i].Id} | Nome: {pessoas[i].Name} | CPF: {pessoas[i].CpfId}");
            }
        }

        Console.Write("\nAperte qualquer tecla");
        Console.ReadKey();

        Menu(ref pessoas, ref posic);
    } 
}