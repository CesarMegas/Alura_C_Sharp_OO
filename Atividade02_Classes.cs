using static System.Runtime.InteropServices.JavaScript.JSType;

class ContaBancaria()
{
    public int NumeroIndicador {  get; set; }
    public string Titular {  get; set; }
    public float Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}

class ModelaCarro()
{
    private int ano;
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public int Ano 
    { 
        get => ano; 
        
        set
        {
            if (value < 1960 || ano > 2023)
            {
                Console.WriteLine("Valor Inválido! Digite um Ano entre 1960 e 2023.");
            }
            else 
            { 
                ano = value;
            }
        } 
    }

    public string DescricaoDetalhada => $"O Fabricante {Fabricante} desenvolveu o Carro {Modelo} no ano {Ano}.";

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

class Produto() 
{
    private double preco;
    private int estoque;

    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco 
    { 
        get => preco; 
        
        set 
        { 
            if (preco < 0) 
            {
                Console.WriteLine("Valor Inválido! Digite um valor Positivo para o Preço do produto.");
            }
            else
            {
                preco = value;
            }
        } 
    }
    public int Estoque 
    { 
        get => estoque; 
        
        set 
        {
            if (estoque < 0)
            {
                Console.WriteLine("Valor Inválido! Digite um valor Positivo para o Estoque do produto.");
            }
            else 
            { 
                estoque = value;
            }
        } 
    
    }

    public string InformacaoDetalhadaDoProduto { get => $"O Produto {Nome} da Marca {Marca} tem o preço R$ {Preco} e {Estoque} unidades em estoque."; }
}
