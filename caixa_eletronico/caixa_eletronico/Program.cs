using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Xml;

internal class Program
{
    /* 
    Trabalho Estrutura de Dados.
    Nome: Rafael Reis da Silveira - GP4 / SI 2023.1
    */


    private static void Main(string[] args)
    {
        contas[] account = new contas[100];
        int quantContasCriadas = 0, posic = 0;

        MenuInicial(ref account, ref quantContasCriadas, ref posic);
    }

    private static void MenuInicial(ref contas[] account, ref int quantContasCriadas, ref int posic)
    {
        Console.Clear();

        int escMenuIncial = 0;

        Console.WriteLine("O melhor banco do mundo");
        Console.WriteLine("\n|  1. Acessar conta  |  2. Criar conta  |");
        Console.Write("Opção: ");
        try
        {
            escMenuIncial = Convert.ToInt32(Console.ReadLine());
        }
        catch { }

        switch (escMenuIncial)
        {
            case 1:
                AcessarConta(ref account, ref posic, ref quantContasCriadas);
                break;
            case 2:
                CriarConta(ref account, ref quantContasCriadas, ref posic);
                break;
        }

        MenuInicial(ref account, ref quantContasCriadas, ref posic);
    }

    private static void AcessarConta(ref contas[] account, ref int posic, ref int quantContasCriadas)
    {
        int codConta = 0;
        string senhaConta = "";
        
        Console.Clear();
        Console.WriteLine("Acessar conta");
        Console.Write("\nDigite o codigo da sua conta: ");
        try
        {
            codConta = Convert.ToInt32(Console.ReadLine());
        }
        catch { }
        Console.Write("Digite sua senha: ");
        senhaConta = Console.ReadLine();

        posic = BinSearch(account, codConta, quantContasCriadas);

        if (posic != -1)
        {
            if (senhaConta == account[posic].senhaConta)
            {
                MenuConta(ref account, posic, ref quantContasCriadas);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSenha incorreta!");
                Console.ResetColor();
                Console.Write("\nAperte qualquer tecla para continuar ");
                Console.ReadKey();
                MenuInicial(ref account, ref quantContasCriadas, ref posic);
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nConta não encontrada!");
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");
            Console.ReadKey();
            MenuInicial(ref account, ref quantContasCriadas, ref posic);
        }
    }

    private static void MenuConta(ref contas[] account, int posic, ref int quantContasCriadas)
    {
        Console.Clear();

        int escAcessarConta = 0;

        Console.Write($"Bem vindo {account[posic].nomeUsuario} ("); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($"{account[posic].numConta}"); Console.ResetColor(); Console.WriteLine(")!");
        Console.WriteLine("\n|  1. Transferência  |  2. Depositar  |  3. Saldo da conta  |  4. Sair  |");
        Console.Write("Opção: ");
        try
        {
            escAcessarConta = Convert.ToInt32(Console.ReadLine());
        }
        catch { }

        switch (escAcessarConta)
        {
            case 1:
                Transferencia(ref account, posic, ref quantContasCriadas);
                break;
            case 2:
                Deposito(ref account, posic, ref quantContasCriadas);
                break;
            case 3:
                SaldoConta(account, posic, ref quantContasCriadas);
                break;
            case 4:
                MenuInicial(ref account, ref quantContasCriadas, ref posic);
                break;
        }

        MenuConta(ref account, posic, ref quantContasCriadas);
    }

    private static void Deposito(ref contas[] account, int posic, ref int quantContasCriadas)
    {
        Console.Clear();

        float valorDeposito = 0;
        string confirmar = "";

        Console.WriteLine("Deposito na conta");
        Console.WriteLine("\nQuanto Você deseja depositar?");
        try
        {
            valorDeposito = Convert.ToSingle(Console.ReadLine());
        }
        catch { }
        
        if (valorDeposito > 0)
        {
            Console.Write("\nConfirmar deposito de ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{valorDeposito} reais");
            Console.ResetColor();
            Console.WriteLine("? (s/n)");
            Console.Write("Opção: ");
            confirmar = Console.ReadLine();

            if (confirmar == "s" || confirmar == "S")
            {
                account[posic].saldoConta += valorDeposito;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nValor não depositado ");
                Console.ResetColor();
                Console.Write("\nAperte qualquer tecla para continuar ");
                Console.ReadKey();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O valor deve ser maior que 0,00 ");
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");
            Console.ReadKey();
        }

        MenuConta(ref account, posic, ref quantContasCriadas);
    }

    private static void Transferencia(ref contas[] account, int posic, ref int quantContasCriadas)
    {
        int codContaDestino = 0, posicContaDestino = 0;
        float valorDeposito = 0;
        string confirmar = "";

        Console.Clear();

        Console.WriteLine("Transferencia");
        Console.Write("\nDigite o cod da conta destinataria: ");
        try
        {
            codContaDestino = Convert.ToInt32(Console.ReadLine());
        }
        catch { }

        posicContaDestino = BinSearch(account, codContaDestino, quantContasCriadas);

        if (posicContaDestino != -1 && codContaDestino != account[posic].numConta)
        {
            Console.Write("Digite o valor a ser depositado: ");
            try
            {
                valorDeposito = Convert.ToSingle(Console.ReadLine());
            }
            catch { }

            if (valorDeposito > 0)
            {
                Console.Write("\nConfirma que deseja enviar ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{valorDeposito} reais ");
                Console.ResetColor();
                Console.Write("para ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{account[posicContaDestino].nomeUsuario}");
                Console.ResetColor();
                Console.WriteLine("? (s/n)");
                Console.Write("Opção: ");
                confirmar = Console.ReadLine();

                if (confirmar == "s" || confirmar == "S")
                {
                    if (account[posic].saldoConta >= valorDeposito)
                    {
                        account[posic].saldoConta -= valorDeposito;
                        account[posicContaDestino].saldoConta += valorDeposito;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSaldo insuficiente!!");
                        Console.ResetColor();
                        Console.Write("Saldo disponível: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{account[posic].saldoConta} reais ");
                        Console.ResetColor();
                        Console.Write("\nAperte qualquer tecla para continuar ");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Transferencia cancelada ");
                    Console.ResetColor();
                    Console.Write("\nAperte qualquer tecla para continuar ");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO valor deve ser maior que 0,00 ");
                Console.ResetColor();
                Console.Write("\nAperte qualquer tecla para continuar ");
                Console.ReadKey();
            }
        }
        else if (codContaDestino == account[posic].numConta)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nConta destinataria não pode ser a mesma que remetente ");
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");
            Console.ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nConta do destinatario não encontrada!");
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");
            Console.ReadKey();
        }

        MenuConta(ref account, posic, ref quantContasCriadas);
    }

    private static void SaldoConta(contas[] account, int posic, ref int quantContasCriadas)
    {
        Console.Clear();

        Console.WriteLine("Saldo");
        Console.Write("\nSeu saldo atual é de ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{account[posic].saldoConta} reais");
        Console.ResetColor();
        Console.Write("\nAperte qualquer tecla para continuar ");
        Console.ReadKey();

        MenuConta(ref account, posic, ref quantContasCriadas);
    }

    private static void CriarConta(ref contas[] account, ref int quantContasCriadas, ref int posic)
    {
        Console.Clear();
        
        Console.WriteLine("Criar conta");
        Console.Write("\nDigite seu nome: ");
        account[quantContasCriadas].nomeUsuario = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        account[quantContasCriadas].senhaConta = Console.ReadLine();

        if (account[quantContasCriadas].nomeUsuario != "" && account[quantContasCriadas].senhaConta != "")
        {
            account[quantContasCriadas].numConta = quantContasCriadas + 1;

            Console.Write("\nO numero da sua conta é: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(account[quantContasCriadas].numConta);
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");

            quantContasCriadas++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nConta não criada!");
            Console.ResetColor();
            Console.Write("\nAperte qualquer tecla para continuar ");
        }

        Console.ReadKey();

        MenuInicial(ref account, ref quantContasCriadas, ref posic);
    }

    struct contas
    {
        public int numConta;
        public float saldoConta;
        public string nomeUsuario;
        public string senhaConta;
        public int extratoDaConta;
    }

    private static int BinSearch(contas[] x, int key, int max)
    {
        int middle, pos = -1, inf = 0, sup = max;

        while (inf <= sup)
        {
            middle = Convert.ToInt32(inf + ((sup - inf) / 2));
            if (x[middle].numConta == key)
            {
                pos = middle;
                inf = sup + 1;
            }
            else if (x[middle].numConta < key)
            {
                inf = middle + 1;
            }
            else
            {
                sup = middle - 1;
            }
        }

        return pos;
    }
}