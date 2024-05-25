import java.util.Scanner;


public class CadastrarVeiculo {

    private static Scanner readNumero = new Scanner(System.in);


    public void Show()
    {
        CadastraVeiculo();
    }


    private void CadastraVeiculo()
    {
        Main.LimparTela();

        System.out.println("Cadastro de veiculos\n");
        System.out.println("Escolha uma das opcoes: ");
        System.out.println("|  1.Carro  |  2.Moto  |  3.Voltar  |");
        System.out.print("Opcao: ");

        int esc = 0;
        try
        {
            esc = readNumero.nextInt();
        } catch (Exception e) {}
        readNumero.nextLine();

        switch (esc) {
            case 1:
                CadastrarCarro cadastrarCarro = new CadastrarCarro();
                cadastrarCarro.Show();
                break;
            case 2:
                CadastrarMoto cadastrarMoto = new CadastrarMoto();
                cadastrarMoto.Show();
                break;
            case 3:
                break;
        }
    }
}
