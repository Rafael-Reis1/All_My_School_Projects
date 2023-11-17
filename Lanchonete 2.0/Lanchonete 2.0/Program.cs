using System.ComponentModel.Design;

internal class Program
{
    //Variáveis global
    private static int posic = 0;
    private static float totalGeral = 0;
    private static string relatorio;
    private static int[] quant = new int[21];
    private static int[,] quantVenda = new int[21, 21];
    private static float[] valor = new float[21], total = new float[9];
    private static float[,] valorVenda = new float[21, 21];
    private static string[] descricao = new string[21], mesa = new string[9];
    private static string[,] descricaoVenda = new string[21, 21];


    //Inicia o programa
    private static void Main(string[] args)
    {
        for (int i = 0; i < 9; i++)
        {
            mesa[i] = "Vazio";
        }
        Menu();
    }

    //Menu principal
    private static void Menu()
    {
        int opcao = 22;

        Console.Clear();
        Console.WriteLine("Menu\n");
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("\nMesa 1: " + mesa[0] + "    " + "Mesa 2: " + mesa[1] + "    " + "Mesa 3: " + mesa[2]);
        Console.WriteLine("\nMesa 5: " + mesa[3] + "    " + "Mesa 6: " + mesa[4] + "    " + "Mesa 7: " + mesa[5]);
        Console.WriteLine("\nMesa 8: " + mesa[6] + "    " + "Mesa 7: " + mesa[7] + "    " + "Mesa 9: " + mesa[8]);
        Console.WriteLine("\n|  Cod. mesa      |  11. Estoque         |  12. Renomear  |");
        Console.WriteLine(  "|  13. Relatório  |  14. Encerrar        |");
        Console.Write("Opção: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
            opcao -= 1;
        }
        catch { }

        switch (opcao)
        {
            case 10:
                Estoque();
                break;
            case 11:
                Renomear();
                break;
            case 12:
                Relatorio();
                break;
            case 13:
                Encerrar();
                break;

            default:
                if (opcao >= 0 && opcao <= 8)
                {
                    Vendas(opcao);
                }
                else
                {
                    Console.Write("Opção invalida!");
                    Console.ReadKey();
                    Menu();
                }
                break;
        }
        Menu();
    }





    //Menu de vendas
    private static void Vendas(int codMesa)
    {
        string confirmacao;
        int opcao = 22;

        if (mesa[codMesa] == "Vazio" || mesa[codMesa] == "")
        {
            Console.Write("\nDigite o nome do cliente: ");
            mesa[codMesa] = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Mesa: " + mesa[codMesa]);
        Console.WriteLine("\nCod - Descrição - Quantidade - Valor");
        Console.WriteLine("===================================================================");

        for (int i = 0; i < 20; i++)
        {
            if (quantVenda[codMesa, i] > 0)
            {
                Console.WriteLine((i + 1) + "    -    " + descricaoVenda[codMesa, i] + "    -    " + quantVenda[codMesa, i] + "    -    " + valorVenda[codMesa, i]);
            }
        }

        Console.WriteLine("===================================================================");
        Console.WriteLine("Total: " + total[codMesa]);
        Console.WriteLine("\n|  -1. Consultar tabela de produtos  |  -2. Encerrar pedido  |");
        Console.WriteLine("|  -3. Cancelar produto              |  -4. Menu             |  Código do produto  |");
        Console.Write("Cod: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
            opcao -= 1;
        }
        catch { }

        switch (opcao)
        {
            case -2:
                ConsultarTabelaProdutos(codMesa);
                break;
            case -3:
                EncerrarVenda(codMesa);
                break;
            case -4:
                CancelarProduto(codMesa, opcao);
                break;
            case -5:
                Menu();
                break;
            default:
                if (opcao >= 0 && opcao <= 8)
                {
                    LancarProdutoVenda(opcao, codMesa);
                }
                else
                {
                    Console.Write("Opção invalida!");
                    Console.ReadKey();
                    Vendas(codMesa);
                }
                break;
        }
        Vendas(codMesa);
    }

    //Lança produtos na venda
    private static void LancarProdutoVenda(int opcao, int codMesa)
    {
        string confirmacao;
        if (quant[opcao] > 0)
        {
            Console.WriteLine("\n" + descricao[opcao] + "   -   " + valor[opcao]);
            Console.Write("Confirmar (s/n): ");
            confirmacao = Console.ReadLine();
            if (confirmacao == "s")
            {
                do
                {
                    Console.Write("Quantidade: ");
                    try
                    {
                        quantVenda[codMesa, opcao] += Convert.ToInt32(Console.ReadLine());
                    }
                    catch { }
                } while (quantVenda[codMesa, opcao] > quant[opcao]);
                descricaoVenda[codMesa, opcao] = descricao[opcao];
                valorVenda[codMesa, opcao] += valor[opcao] * quantVenda[codMesa, opcao];
                total[codMesa] += valor[opcao] * quantVenda[codMesa, opcao];
            }
            quant[opcao] -= quantVenda[codMesa, opcao];
            Vendas(codMesa);
        }
        else
        {
            Console.WriteLine("Produto não existe!");
            Console.ReadKey();
            Vendas(codMesa);
        }
    }

    //Consulta estoque de produtos
    private static void ConsultarTabelaProdutos(int codMesa)
    {
        Console.Clear();
        Console.WriteLine("Estoque");
        Console.WriteLine("\nCod - Descrição - Valor - Quantidade");
        Console.WriteLine("===================================================================");
        TabelaProdutos();
        Console.Write("===================================================================");
        Console.ReadKey();
        Vendas(codMesa);
    }

    //Cancela um produto da venda
    private static void CancelarProduto(int codMesa, int opcao)
    {
        int cod = 22;
        Console.Write("\nDigite o cod do produto: ");
        try
        {
            cod = Convert.ToInt32(Console.ReadLine());
            cod -= 1;
        }
        catch { }
        quant[cod] += quantVenda[codMesa, cod];
        if (quantVenda[codMesa, cod] > 0)
        {
            for (int i = cod; i < 20; i++)
            {
                valorVenda[codMesa, i] = valorVenda[codMesa, (i + 1)];
                quantVenda[codMesa, i] = quantVenda[codMesa, (i + 1)];
            }
        }
        else
        {
            Console.Write("Produto não existe!");
            Console.ReadKey();
        }
        Vendas(codMesa);
    }

    //Encerrando a venda
    private static void EncerrarVenda(int codMesa)
    {
        string confirmacao;
        Console.Write("\nTem certeza (s/n): ");
        confirmacao = Console.ReadLine();
        if (confirmacao == "s")
        {
            for (int i = 0; i < 20; i++)
            {
                if (quantVenda[codMesa, i] > 0)
                {
                    relatorio += Convert.ToString("\n" + (i + 1) + "    -    " + descricao[i] + "    -    " + quantVenda[codMesa, i] + "    -    " + valorVenda[codMesa, i]);
                }
            }
            mesa[codMesa] = "Vazio";
            for (int i = 0; i < 20; i++)
            {
                quantVenda[codMesa, i] = 0;
                valorVenda[codMesa, i] = 0;
            }
            totalGeral += total[codMesa];
            total[codMesa] = 0;
            Menu();
        }
        Vendas(codMesa);
    }





    //Menu de estoque
    private static void Estoque()
    {
        int opcao = 22;

        Console.Clear();
        Console.WriteLine("Estoque\n");
        Console.WriteLine("Cod - Descrição - Valor - Quantidade");
        Console.WriteLine("===================================================================");
        TabelaProdutos();
        Console.WriteLine("===================================================================");
        Console.WriteLine("\n|  1. Cadastrar produto  |  2. Adicionar saldo  |");
        Console.WriteLine("|  3. Alterar valor      |  4. Excluir produto  | 5.Menu  |");
        Console.Write("Opção: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
        }
        catch { }

        switch (opcao)
        {
            case 1:
                CadastroProduto();
                break;
            case 2:
                AdicionarSaldo();
                break;
            case 3:
                AlterarValor();
                break;
            case 4:
                ExcluirProduto();
                break;
            case 5:
                Menu();
                break;
            default:
                Console.WriteLine("Opção invalida!");
                Console.ReadKey();
                break;
        }
        Estoque();
    }

    //Escreve a tabela de produtos cadastrados na tela
    private static void TabelaProdutos()
    {
        for (int i = 0; i < 20; i++)
        {
            if (quant[i] > 0)
            {
                Console.WriteLine((i + 1) + "    -    " + descricao[i] + "    -    " + valor[i] + "    -    " + quant[i]);
            }
        }
    }

    //Cadastrando produtos no estoque
    private static void CadastroProduto()
    {
        if (posic < 20)
        {
            Console.Clear();
            Console.WriteLine("Cadastro de produtos\n");
            Console.Write("Digite o nome do produto: ");
            try
            {
                descricao[posic] = Console.ReadLine();
            }
            catch { }
            Console.Write("Digite o valor: ");
            try
            {
                valor[posic] = Convert.ToSingle(Console.ReadLine());
            }
            catch { }
            Console.Write("Digite a quantidade: ");
            try
            {
                quant[posic] = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            if (valor[posic] > 0 && quant[posic] > 0)
            {
                posic++;
            }
        }
        else
        {
            Console.Write("Limite alcançado!");
            Console.ReadKey();
        }
        Estoque();
    }

    //Adicionar saldo a um produto
    private static void AdicionarSaldo()
    {
        int cod = 22;
        Console.Write("\nDigite o cod do produto: ");
        try
        {
            cod = Convert.ToInt32(Console.ReadLine());
            cod -= 1;
        }
        catch { }
        if (cod >= 0 && cod < 20)
        {
            if (quant[cod] > 0)
            {
                Console.Write("Digite a quantidade: ");
                try
                {
                    quant[cod] += Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            }
            else
            {
                Console.Write("Opção invalida!");
                Console.ReadKey();
            }
        }
        else
        {
            Console.Write("Produto não existe!");
            Console.ReadKey();
        }
        Estoque();
    }

    //Alterar valor de um produto
    private static void AlterarValor()
    {
        int cod = 22;
        Console.Write("\nDigite o cod do produto: ");
        try
        {
            cod = Convert.ToInt32(Console.ReadLine());
            cod -= 1;
        }
        catch { }
        if (cod >= 0 && cod < 20)
        {
            if (quant[cod] > 0)
            {
                Console.Write("Digite o novo valor: ");
                try
                {
                    valor[cod] = Convert.ToSingle(Console.ReadLine());
                }
                catch { }
            }
            else
            {
                Console.Write("Opção invalida!");
                Console.ReadKey();
            }
        }
        else
        {
            Console.Write("Produto não existe!");
            Console.ReadKey();
        }
        Estoque();
    }

    //Excluir produto
    private static void ExcluirProduto()
    {
        int cod = 22;
        Console.Write("\nDigite o cod do produto: ");
        try
        {
            cod = Convert.ToInt32(Console.ReadLine());
            cod -= 1;
        }
        catch { }
        if (cod >= 0 && cod <= 20)
        {
            if (quant[cod] > 0)
            {
                for (int i = cod; i < 20; i++)
                {
                    descricao[i] = descricao[i + 1];
                    valor[i] = valor[i + 1];
                    quant[i] = quant[i + 1];
                }
                if (posic > 0)
                {
                    posic--;
                }
            }
            else
            {
                Console.Write("Produto não existe!");
                Console.ReadKey();
            }
        }
        else
        {
            Console.Write("Produto não existe!");
            Console.ReadKey();
        }
        Estoque();
    }





    //Muda o nome da pessoa na mesa
    private static void Renomear()
    {
        int opcao = 22;
        Console.Write("\nDigite o cod da mesa: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
            opcao -= 1;
        }
        catch { }
        if (opcao >= 0 && opcao < 9)
        {
            Console.Write("Digite o novo nome: ");
            mesa[opcao] = Console.ReadLine();
        }
        else
        {
            Console.Write("Mesa não existe!");
            Console.ReadKey();
        }
        Menu();
    }





    //Consulta do relatorio de vendas
    private static void Relatorio()
    {
        Console.Clear();
        Console.WriteLine("Relatorio\n");
        Console.WriteLine("Cod - Descrição - Quantidade - Valor\n");
        Console.Write("===================================================================");
        Console.WriteLine(relatorio);
        Console.WriteLine("===================================================================");
        Console.WriteLine("Total: " + totalGeral);
        Console.ReadKey();
        Menu();
    }





    //Encerra o programa
    private static void Encerrar()
    {
        Console.Clear();
        Console.WriteLine("Até a proxima!\n");
        Console.WriteLine("Cod - Descrição - Quantidade - Valor\n");
        Console.Write("===================================================================");
        Console.WriteLine(relatorio);
        Console.WriteLine("===================================================================");
        Console.WriteLine("Total: " + totalGeral);
        Console.ReadKey();
        Environment.Exit(0);
    }
}