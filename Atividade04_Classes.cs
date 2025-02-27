//Conta Bancária
class Titular
{
    //Inicializador do Titular
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
}

class Conta
{
    //Inicializador da Conta
    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite) 
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }

    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    //Mostra as informações detalhadas da Conta
    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}

//Catálogo de Jogos
class Jogo
{
    //Inicializador do Jogo
    public Jogo(string nome, string genero, int anoDeLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoDeLancamento = anoDeLancamento;
    }

    public string Nome { get; }
    public string Genero { get; }
    public int AnoDeLancamento { get; }
}

class CatalogoDeJogos
{
    //Inicializador do Catálogo de Jogos
    public CatalogoDeJogos()
    {
        Jogos = new List<Jogo>();
    }

    private List<Jogo> Jogos { get; set; }

    public bool CatalogoVazio => Jogos.Count == 0;

    //Método para Adicionar Jogos ao Catálogo
    public void AdicionarJogoNovo(string nome, string genero, int anoDeLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoDeLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($" Jogo | {nome} | Adicionado ao Catálogo!");
    }

    //Método para Listar o Catálogo
    public void ListarCatalogo()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O Catálogo de Jogos está Vazio...");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"· {jogo.Nome} / Gênero: {jogo.Genero} / Lançamento: {jogo.AnoDeLancamento}");
            }
        }
    }
}
