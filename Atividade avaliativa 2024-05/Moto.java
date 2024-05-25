public class Moto extends Veiculo{

    private String cilindradas;
    private double consumoPorKM;
    private double velocidadeMax;

    public void setCilindradas(String cilindradas) { this.cilindradas = cilindradas; }
    public String getCilindradas() { return cilindradas; }

    public void setConsumoPorKM(double consumoPorKM) { this.consumoPorKM = consumoPorKM; }
    public double getConsumoPorKM() { return consumoPorKM; }

    public void setVelocidadeMax(double velocidadeMax) { this.velocidadeMax = velocidadeMax; }
    public double getVelocidadeMax() { return velocidadeMax; }
    
    public String getDadosVaiculo()
    {
        String resultado = "";

        resultado = "Marca: " + this.getMarca();
        resultado += "\nModelo: " + this.getModelo();
        resultado += "\nPlaca: " + this.getPlaca();
        resultado += "\nAno: " + this.getAno();
        resultado += "\nKilometragem: " + this.getKilometragem() + " km";
        resultado += "\nCilindradas: " + this.cilindradas + " cilindradas";
        resultado += "\nConsumo: " + this.consumoPorKM + " km/l";
        resultado += "\nVelocidade maxima: " + this.velocidadeMax + " km/h";

        return resultado;
    }

    @Override
    void calcularConsumo(double distancia) {
        System.out.println("O consumo é de: " + (distancia / (consumoPorKM)) + " litros");
    }
}
