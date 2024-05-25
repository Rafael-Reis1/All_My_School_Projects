import java.util.Scanner;


public class ConsultaDadosVeiculo {
    
    private static Scanner readString = new Scanner(System.in).useDelimiter("\n");
    private static Scanner readNumero = new Scanner(System.in);


    public void Show()
    {
        ConsultarDadosVeiculo();
    }

    private void ConsultarDadosVeiculo()
    {
        Main.LimparTela();

        System.out.println("Dados dos veiculo\n");
        System.out.print("1.Carro 2.Moto: ");
        int esc = 0;
        int cod = 0;
        try
        {
            esc = readNumero.nextInt();
            if (esc >= 1 && esc <= 2)
            {
                System.out.print("Digite o codigo do veiculo: ");
                cod = readNumero.nextInt();
            }
        } catch (Exception e) {}
        readNumero.nextLine();

        switch (esc) {
            case 1:
                try
                {
                    System.out.print("\n");
                    System.out.print(Main.carro.get(cod - 1).getDadosVaiculo());
                    System.out.print("\n\nAperte enter para continuar ");
                    String pause = readString.next();
                } 
                catch(Exception e)
                {
                    System.out.print("\nCarro nao existe! ");
                    String pause = readString.next();
                }
                break;
        
            case 2:
            try
                {
                    System.out.print("\n");
                    System.out.print(Main.moto.get(cod - 1).getDadosVaiculo());
                    System.out.print("\n\nAperte enter para continuar ");
                    String pause = readString.next();
                } 
                catch(Exception e)
                {
                    System.out.print("\nMoto nao existe! ");
                    String pause = readString.next();
                }
                break;
            default:
                System.out.print("\nCodigo incorreto ");
                String pause = readString.next();
                ConsultarDadosVeiculo();
        }
    }
}
