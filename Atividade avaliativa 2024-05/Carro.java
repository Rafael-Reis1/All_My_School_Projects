public class Carro extends Veiculo{

    private double capacidadeTanque;
    private double consumoPorKM;
    private int qtdePortas;

    public Carro()
    {
        capacidadeTanque = 0;
        consumoPorKM = 0;
        qtdePortas = 0;
    }

    public void setCapacidadeTanque(double capacidadeTanque) { this.capacidadeTanque = capacidadeTanque; }

    public double getCapacidadeTanque() { return this.capacidadeTanque; }

    public void setConsumoPorKM(double consumoPorKM) { this.consumoPorKM = consumoPorKM; }

    public double getConsumoPorKM() { return this.consumoPorKM; }

    public void setQtdePortas(int qtdePortas) { this.qtdePortas = qtdePortas; }

    public int getQtdePortas() { return this.qtdePortas; }

    public String getDadosVaiculo()
    {
        String resultado = "";
        resultado = "Marca: " + this.getMarca();
        resultado += "\nModelo: " + this.getModelo();
        resultado += "\nPlaca: " + this.getPlaca();
        resultado += "\nAno: " + this.getAno();
        resultado += "\nKilometragem: " + this.getKilometragem() + " km";
        resultado += "\nCapacidade do tanque: " + this.capacidadeTanque;
        resultado += "\nConsumo: " + this.consumoPorKM + " km/l";
        resultado += "\nQuantidade de portas: " + this.qtdePortas;
        
        return resultado;
    }

    @Override
    void calcularConsumo(double distancia) 
    {
        System.out.println("O consumo é de: " + (distancia / consumoPorKM) + " litros");
    }
}
