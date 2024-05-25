import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    private static Scanner readNumero = new Scanner(System.in);
    public static List<Carro> carro = new ArrayList<Carro>();
    public static List<Moto> moto = new ArrayList<Moto>();

    public static void main(String[] args)
    {
        LimparTela();

        System.out.println("Bem vindo!\n");
        System.out.println("Escolha uma das opcoes");
        System.out.println("|  1.Cadastrar veiculo  |  2.Consultar dados veiculo  |  3.Calcular consumo |");
        System.out.print("Opcao: ");

        PrintaVeiculosTela();
        
        int esc = 0;
        try
        {
            esc = readNumero.nextInt();
        } catch (Exception e) {}
        readNumero.nextLine();
        

        switch (esc) {
            case 1:
                CadastrarVeiculo cadastrarVeiculo = new CadastrarVeiculo();
                cadastrarVeiculo.Show();
                break;
        
            case 2:
                ConsultaDadosVeiculo consultaDadosVeiculo = new ConsultaDadosVeiculo();
                consultaDadosVeiculo.Show();
                break;
            case 3:
                CalcularConsumo calcularConsumo = new CalcularConsumo();
                calcularConsumo.Show();
        }

        main(args);
    }

    private static void PrintaVeiculosTela()
    {
        
        DefinePosicaoCursor(0, 7);
        
        System.out.print("Motos:\n\n");
        
        for (int i = 0; i < moto.size(); i++) 
        {
            System.out.print((i+1) + ". " + moto.get(i).getModelo() + "\n");
        }

        DefinePosicaoCursor(40, 7);

        System.out.print("Carros:");
        
        int y = 9;
        for (int i = 0; i < carro.size(); i++) 
        {
            DefinePosicaoCursor(40, y);
            System.out.print((i+1) + ". " + carro.get(i).getModelo());
            y++;
        }

        DefinePosicaoCursor(8, 5);
    }

    public static void DefinePosicaoCursor(int x, int y)
    {
        char escCode = 0x1B;
        int row = y; int column = x;
        System.out.print(String.format("%c[%d;%df",escCode,row,column));
    }

    public static void LimparTela()
    {
        System.out.print("\033[H\033[2J");  
        System.out.flush();
    }
}