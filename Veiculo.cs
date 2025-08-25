
namespace C_Sharp;

public class Veiculo
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }

    public Veiculo(string placa, string modelo, string cor)
    {
        Placa = placa;
        Modelo = modelo;
        Cor = cor;
    }
}