class ContaBancaria()
{
    public int numeroIndicador;
    public string titular;
    public float saldo;
    public string senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}

class ModelaCarro()
{
    public string modelo;
    public int ano;
    public string marca;

    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando!");
    }

    public void Frear()
    {
        Console.WriteLine("O carro está freando!");
    }

    public void Buzinar()
    {
        Console.WriteLine("O carro buzinou!");
    }
}
