import java.util.Scanner;

public class CalcularConsumo {

    private static Scanner readNumero = new Scanner(System.in);
    private static Scanner readString = new Scanner(System.in).useDelimiter("\n");

    public void Show()
    {
        CalculaConsumo();
    }

    private void CalculaConsumo()
    {
        Main.LimparTela();
        System.out.println("Calcular consumo\n");
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
                    Carro carro = Main.carro.get(cod - 1);
                    System.out.print("Digite a distancia pecorrida em km: ");
                    double distanciaCarro = readNumero.nextDouble();
                    System.out.print("\n");
                    carro.calcularConsumo(distanciaCarro);
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
                    Moto moto = Main.moto.get(cod - 1);
                    System.out.print("Digite a distancia pecorrida em km: ");
                    double distanciaMoto = readNumero.nextDouble();
                    System.out.print("\n");
                    moto.calcularConsumo(distanciaMoto);
                    System.out.print("\nAperte enter para continuar ");
                    String pause = readString.next();
                }
                catch(Exception e)
                {
                    System.out.print("\nCarro nao existe! ");
                    String pause = readString.next();
                }
                break;
        }
    }
}
