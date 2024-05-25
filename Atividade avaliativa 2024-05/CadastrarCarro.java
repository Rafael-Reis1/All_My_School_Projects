import java.util.Scanner;


public class CadastrarCarro {

    private static Scanner readString = new Scanner(System.in).useDelimiter("\n");
    private static Scanner readNumero = new Scanner(System.in);


    public void Show()
    {
        CadastraCarro();
    }

    private void CadastraCarro()
    {
        Main.LimparTela();
        Carro carroCadastro = new Carro();
        
        System.out.println("Cadastrar carro\n");
        System.out.print("Digite a marca: ");
        carroCadastro.setMarca(readString.next());
        System.out.print("Digite o modelo: ");
        carroCadastro.setModelo(readString.next());
        System.out.print("Digite a placa: ");
        carroCadastro.setPlaca(readString.next());
        try
        {
            System.out.print("Digite o ano: ");
            carroCadastro.setAno(readNumero.nextInt());
        }
        catch (Exception e)
        {
            carroCadastro.setAno(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite a kilometrageam em km: ");
            carroCadastro.setKilometragem(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            carroCadastro.setKilometragem(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite a capacidade do tanque em litros: ");
            carroCadastro.setCapacidadeTanque(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            carroCadastro.setCapacidadeTanque(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite o consumo em km/l: ");
            carroCadastro.setConsumoPorKM(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            carroCadastro.setConsumoPorKM(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite a quantidade de portas: ");
            carroCadastro.setQtdePortas(readNumero.nextInt());
        }
        catch (Exception e)
        {
            carroCadastro.setQtdePortas(0);
            readNumero.nextLine();
        }
        readNumero.nextLine();

        Main.carro.add(carroCadastro);
    }
}
