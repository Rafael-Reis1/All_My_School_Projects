/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author rafae
 */
public class Carros extends CadastroDAO {
    
    private String fabricante;
    private String modelo;
    private int ano;
    private double potencia;
    private int nota; 

    public Carros(){
        this.fabricante = "";
        this.modelo = "";
        this.ano = 0;
        this.potencia = 0;
        this.nota = 0;
    }

    public void setFabricante(String fabricante) {
        this.fabricante = fabricante;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public void setPotencia(double potencia) {
        this.potencia = potencia;
    }

    public void setNota(int nota) {
        this.nota = nota;
    }
    
    public void cadastrar()
    {
        insertMySQL(this.fabricante, this.modelo, this.ano, this.potencia, this.nota);
    }
}
