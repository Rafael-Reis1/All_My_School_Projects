import java.util.Scanner;


public class CadastrarMoto {
    private static Scanner readString = new Scanner(System.in).useDelimiter("\n");
    private static Scanner readNumero = new Scanner(System.in);

    public void Show()
    {
        CadastraMoto();
    }

    private void CadastraMoto()
    {
        Main.LimparTela();
        Moto motoCadastro = new Moto();
        
        System.out.println("Cadastrar moto\n");
        System.out.print("Digite a marca: ");
        motoCadastro.setMarca(readString.next());
        System.out.print("Digite o modelo: ");
        motoCadastro.setModelo(readString.next());
        System.out.print("Digite a placa: ");
        motoCadastro.setPlaca(readString.next());
        try
        {
            System.out.print("Digite o ano: ");
            motoCadastro.setAno(readNumero.nextInt());
        }
        catch (Exception e)
        {
            motoCadastro.setAno(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite a kilometrageam em km: ");
            motoCadastro.setKilometragem(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            motoCadastro.setKilometragem(0);
            readNumero.nextLine();
        }

        System.out.print("Digite a quantidade de cilindradas: ");
        motoCadastro.setCilindradas(readString.next());
        
        try
        {
            System.out.print("Digite o consumo em km/l: ");
            motoCadastro.setConsumoPorKM(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            motoCadastro.setConsumoPorKM(0);
            readNumero.nextLine();
        }

        try
        {
            System.out.print("Digite a velocidade maxima: ");
            motoCadastro.setVelocidadeMax(readNumero.nextDouble());
        }
        catch (Exception e)
        {
            motoCadastro.setVelocidadeMax(0);
            readNumero.nextLine();
        }
        readNumero.nextLine();

        Main.moto.add(motoCadastro);
    }
}
