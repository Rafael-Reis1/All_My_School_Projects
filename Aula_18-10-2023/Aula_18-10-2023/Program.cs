using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int quantVenda = 0, escMenuPrincipal = 10, escVenda = 1000001, escMenuCadastro = 5, escCadastro = 1000001;
        string confirmacao = "", relatorio = "", relatorioFinal = "";
        float totalGeral = 0;
        int[] quantEstoque = new int[1000001], quantEstoqueVenda = new int[1000001];
        float[] preco = new float[1000001], precoVenda = new float[1000001];
        string[] nomeProdutos = new string[1000001], nomeProdutosVenda = new string[1000001];

        while (escMenuPrincipal != 4)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("\nEscolha uma das opções:");
            Console.WriteLine("\n|  1. Venda      |  2. Estoque   |");
            Console.WriteLine("\n|  3. Relatório  |  4. Encerrar  |");
            Console.WriteLine("\nCódigo: ");
            try
            {
                escMenuPrincipal = Convert.ToInt32(Console.ReadLine());

                if (escMenuPrincipal == 1)
                {
                    VendaDeProdutos(relatorio, quantVenda, escVenda, quantEstoqueVenda, nomeProdutosVenda, precoVenda, preco, nomeProdutos, confirmacao, quantEstoque, totalGeral, relatorioFinal);
                }

                if (escMenuPrincipal == 2)
                {
                    Estoque(escMenuCadastro, quantEstoque, nomeProdutos, preco, escCadastro);
                }

                //Relatório
                if (escMenuPrincipal == 3)
                {
                    EscreverRelatorio(relatorioFinal, totalGeral);
                }
            }
            catch { }
        }

        Encerramento(relatorioFinal, totalGeral);
    }








    //Submenu de vendas
    public static void VendaDeProdutos(string relatorio, int quantVenda, int escVenda, int[] quantEstoqueVenda, string[] nomeProdutosVenda, float[] precoVenda, float[] preco, string[] nomeProdutos, string confirmacao, int[] quantEstoque, float totalGeral, string relatorioFinal)
    {   
        float totalLocal = 0;
        relatorio = "";
        quantVenda = 0;
        escVenda = 1000001;

        Console.Clear();
        while (escVenda != -2)
        {
            Console.WriteLine("Vendas");

            EscreveProdutosTeladeVendas(quantEstoqueVenda, nomeProdutosVenda, precoVenda);

            Console.WriteLine("\nTotal: " + totalLocal);
            Console.WriteLine("\n|  -1. Consultar tabela de produtos  |  -2. Encerrar pedido  |");
            Console.WriteLine("\n|  -3. Cancelar produto              |  Código do produto    |");
            Console.WriteLine("\nCod: ");
            try
            {
                escVenda = Convert.ToInt32(Console.ReadLine());
            }
            catch { }

            if (escVenda >= 0 && escVenda < 1000000)
            {
                LancarVenda(preco, escVenda, nomeProdutos, confirmacao, quantEstoque, quantVenda, nomeProdutosVenda, quantEstoqueVenda, precoVenda, totalLocal, totalGeral);
            }
            else if (escVenda == -1)
            {
                ConsultarTabelaDeProdutos(quantEstoque, nomeProdutos, preco);
            }
            else if (escVenda == -2)
            {
                Console.Clear();
            }
            else if (escVenda == -3)
            {
                CancelarProdutos(escVenda, quantEstoque, quantEstoqueVenda, nomeProdutosVenda, precoVenda, totalLocal, preco, quantVenda, totalGeral);
            }
            else
            {
                Console.WriteLine("\nProduto não existe");
                Console.WriteLine("\n\nEnter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }

        //Faz os relatorios
        for (int i = 0; i < 1000000; i++)
        {
            if (quantEstoqueVenda[i] > 0)
            {
                relatorio += "\n" + i + "  -  " + nomeProdutosVenda[i] + "  -  " + precoVenda[i] + "  -  " + quantEstoqueVenda[i];
            }
            nomeProdutosVenda[i] = "";
            quantEstoqueVenda[i] = 0;
            precoVenda[i] = 0;
        }
        if (quantVenda > 0)
        {
            relatorioFinal += relatorio;
        }
    }

    //Submenu do estoque
    public static void Estoque(int escMenuCadastro, int[] quantEstoque, string[] nomeProdutos, float[] preco, int escCadastro)
    {
        int posic = 0;
        escMenuCadastro = 5;
        while (escMenuCadastro != 0)
        {
            Console.Clear();
            Console.WriteLine("ESTOQUE\n");
            Console.WriteLine("(Cod  -  Descrição  -  Preço  -  Quantidade)\n");
            Console.WriteLine("==============================================\n");

            EscreverProdutosTela(quantEstoque, nomeProdutos, preco);

            Console.WriteLine("\n\n==============================================");
            Console.WriteLine("\n\n|  1. Cadastrar produto  |  2. Reajuste de preço  |");
            Console.WriteLine("\n|  3. Adicionar saldo    |  4. Excluir produto    |  0. Menu inicial  |\n");
            Console.WriteLine("\nCódigo: ");
            try
            {
                escMenuCadastro = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            if (escMenuCadastro == 1)
            {
                CadastroDeProduto(posic, nomeProdutos, preco, quantEstoque);
            }
            else if (escMenuCadastro == 2)
            {
                ReajustePreco(escCadastro, preco);
            }
            else if (escMenuCadastro == 3)
            {
                AdicionaSaldo(escCadastro, preco, quantEstoque);
            }
            else if (escMenuCadastro == 4)
            {
                ExcluirProduto(escCadastro, nomeProdutos, preco, quantEstoque, posic, escMenuCadastro);
            }
        }
    }

    //Cadastra produtos no estoque
    public static void CadastroDeProduto(int posic, string[] nomeProdutos, float[] preco, int[] quantEstoque)
    {
        if (posic < 1000000)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do produto: ");
            nomeProdutos[posic] = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            try
            {
                preco[posic] = Convert.ToSingle(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Digite a quantidade: ");
            try
            {
                quantEstoque[posic] = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            posic++;
        }
        else if (posic > 999999)
        {
            Console.WriteLine("\nLimite alcançado");
            Console.WriteLine("\n\nEnter para voltar");
            Console.ReadLine();
        }
    }

    //Faz o reajuste de preço de um produto
    public static void ReajustePreco(int escCadastro, float[] preco)
    {
        Console.WriteLine("Digite o cod do produto: ");
        try
        {
            escCadastro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o novo Valor: ");
            preco[escCadastro] = Convert.ToSingle(Console.ReadLine());
        }
        catch { }
    }

    //Adiciona saldo a um produto do estoque
    public static void AdicionaSaldo(int escCadastro, float[] preco, int[] quantEstoque)
    {
        int quantLocal = 0;
        Console.WriteLine("Digite o cod do produto: ");
        try
        {
            escCadastro = Convert.ToInt32(Console.ReadLine());
            if (escCadastro >= 0 && escCadastro < 1000000)
            {
                if (preco[escCadastro] > 0)
                {
                    Console.WriteLine("Digite a quantidade: ");
                    try
                    {
                        quantLocal = Convert.ToInt32(Console.ReadLine());
                        quantEstoque[escCadastro] += quantLocal;
                    }
                    catch { }
                }
                else if (preco[escCadastro] <= 0)
                {
                    Console.WriteLine("\nProduto não existe");
                    Console.WriteLine("\n\nEnter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        catch { }
    }

    //Exclui produto do estoque
    public static void ExcluirProduto(int escCadastro, string[] nomeProdutos, float[] preco, int[] quantEstoque, int posic, int escMenuCadastro)
    {
        if (posic > 0 || escMenuCadastro == 4)
        {
            Console.WriteLine("Digite o codigo do produto a ser excluído: ");
            try
            {
                escCadastro = Convert.ToInt32(Console.ReadLine());
                for (int i = escCadastro; i < 1000000; i++)
                {
                    nomeProdutos[i] = nomeProdutos[i + 1];
                    preco[i] = preco[i + 1];
                    quantEstoque[i] = quantEstoque[i + 1];
                }
                if (posic > 0)
                {
                    posic--;
                }
            }
            catch { }
        }
        else
        {
            Console.WriteLine("\nNão existe produto para ser excluído");
            Console.WriteLine("\n\nEnter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }

    //Lançamento de produtos na venda
    public static void LancarVenda(float[] preco, int escVenda, string[] nomeProdutos, string confirmacao, int[] quantEstoque, int quantVenda, string[] nomeProdutosVenda, int[] quantEstoqueVenda, float[] precoVenda, float totalLocal, float totalGeral)
    {
        if (preco[escVenda] > 0.00)
        {
            Console.WriteLine("\n" + nomeProdutos[escVenda] + " - " + preco[escVenda]);
            Console.WriteLine("\n\nConfirmar (s/n): ");
            confirmacao = Console.ReadLine();

            if (confirmacao == "s")
            {
                if (quantEstoque[escVenda] > 0)
                {
                    quantVenda = quantEstoque[escVenda] + 1;
                    while (quantVenda > quantEstoque[escVenda])
                    {
                        Console.WriteLine("Digite a quantidade: ");
                        try
                        {
                            quantVenda = Convert.ToInt32(Console.ReadLine());
                        }
                        catch { }
                        Console.Clear();
                        if (quantVenda > quantEstoque[escVenda])
                        {
                            Console.Clear();
                            Console.WriteLine("Saldo insuficiente");
                        }
                    }
                    quantEstoque[escVenda] -= quantVenda;
                    nomeProdutosVenda[escVenda] = nomeProdutos[escVenda];
                    quantEstoqueVenda[escVenda] += quantVenda;
                    precoVenda[escVenda] += (preco[escVenda] * quantVenda);
                    totalLocal += preco[escVenda] * quantVenda;
                    totalGeral += preco[escVenda] * quantVenda;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saldo insuficiente\n\n");
                }
            }
            else
            {
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("\nProduto não existe");
            Console.WriteLine("\n\nEnter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }

    //Escreve na tela os produtos que foram lançados para a venda
    public static void EscreveProdutosTeladeVendas(int[] quantEstoqueVenda, string[] nomeProdutosVenda, float[] precoVenda)
    {
        for (int i = 0; i < 1000000; i++)
        {
            if (quantEstoqueVenda[i] > 0)
            {
                Console.WriteLine("\n" + i + "  -  " + nomeProdutosVenda[i] + "  -  " + precoVenda[i] + "  -  " + quantEstoqueVenda[i]);
            }
        }
    }

    //Escreve na tela o estoque de produtos na tela
    public static void EscreverProdutosTela(int[] quantEstoque, string[] nomeProdutos, float[] preco)
    {
        for (int i = 0; i < 1000000; i++)
        {
            if (quantEstoque[i] > 0)
            {
                Console.WriteLine("\n" + i + "  -  " + nomeProdutos[i] + "  -  " + preco[i] + "  -  " + quantEstoque[i]);
            }
        }
    }

    //Faz a consulta de produtos cadastrados em estoque
    public static void ConsultarTabelaDeProdutos(int[] quantEstoque, string[] nomeProdutos, float[] preco)
    {
        Console.Clear();
        Console.WriteLine("(Cod  -  Descrição  -  Preço  -  Quantidade)\n");
        Console.WriteLine("==============================================\n");

        EscreverProdutosTela(quantEstoque, nomeProdutos, preco);

        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\n\nEnter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    //Cancela o lançamento de um produto lançado na venda
    public static void CancelarProdutos(int escVenda, int[] quantEstoque, int[] quantEstoqueVenda, string[] nomeProdutosVenda, float[] precoVenda, float totalLocal, float[] preco, int quantVenda, float totalGeral)
    {
        Console.WriteLine("Cod do produto a ser excluído: ");
        try
        {
            escVenda = Convert.ToInt32(Console.ReadLine());
        }
        catch { }
        if (escVenda >= 0 && escVenda < 1000000)
        {
            quantEstoque[escVenda] += quantEstoqueVenda[escVenda];
            nomeProdutosVenda[escVenda] = "";
            quantEstoqueVenda[escVenda] = 0;
            precoVenda[escVenda] = 0;
            totalLocal -= preco[escVenda] * quantVenda;
            totalGeral -= preco[escVenda] * quantVenda;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nProduto não existe");
            Console.WriteLine("\n\nEnter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }

    //Escreve o relatório de vendas na tela
    public static void EscreverRelatorio(string relatorioFinal, float totalGeral)
    {
        Console.Clear();
        Console.WriteLine("RELATORIO DE VENDAS \n\n");
        Console.WriteLine("(Cod  -  Descrição  -  Preço  -  Quantidade)\n");
        Console.WriteLine("==============================================\n");
        Console.WriteLine(relatorioFinal);
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nTotal: " + totalGeral);
        Console.WriteLine("\n\nEnter para voltar");
        Console.ReadLine();
    }

    //Escreve o relatório final na tela
    public static void Encerramento(string relatorioFinal, float totalGeral)
    {
        Console.Clear();
        Console.WriteLine("RELATORIO DE VENDAS \n\n");
        Console.WriteLine("(Cod  -  Descrição  -  Preço  -  Quantidade)\n");
        Console.WriteLine("==============================================\n");
        Console.WriteLine(relatorioFinal);
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nTotal: " + totalGeral);
        Console.ReadLine();
    }
}