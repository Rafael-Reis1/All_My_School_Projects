abstract class Veiculo
{
    private String marca;
    private String modelo;
    private String placa;
    private int ano;
    private double kilometragem;

    public Veiculo()
    {
        this.marca = "";
        this.modelo = "";
        this.placa = "";
        this.ano = 0;
        this.kilometragem = 0;
    }

    public void setMarca(String marca) { this.marca = marca; }
    public String getMarca() { return this.marca; }

    public void setModelo(String modelo) { this.modelo = modelo; }
    public String getModelo() { return this.modelo; }

    public void setPlaca(String placa) { this.placa = placa; }
    public String getPlaca() { return this.placa; }

    public void setAno(int ano) { this.ano = ano; }
    public int getAno() { return this.ano; }

    public void setKilometragem(double kilometragem) { this.kilometragem = kilometragem; }
    public double getKilometragem() { return this.kilometragem; }

    abstract void calcularConsumo(double distancia);
}