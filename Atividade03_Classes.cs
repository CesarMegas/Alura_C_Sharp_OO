//Conta Bancária
class Titular
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cpf { get; set; }
}

class Conta 
{
    public Titular Titular { get; set; }
    public string Agencia { get; set; }
    public string NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string InformacoesDetalhadas => $"Número da Conta: {this.NumeroDaConta} | Agência: {this.Agencia} | Titular: {this.Titular.Nome} | Saldo: R$ {this.Saldo}"; 
    
}

//Mercado
class Produto 
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
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 5;
            }
        } 
    }

    public int EmEstoque 
    {
        get => estoque; 
        
        set 
        {
            if (value > 0) 
            {
                estoque = value;
            }
            else
            {
                estoque = 0;
            }
        } 
    }

    public string DescricaoDoProduto => $"{this.Nome} da Marca {this.Marca} | Valor: R$ {this.preco} | Quantidade em Estoque: {this.estoque}";
}

//Escola
class Aluno 
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>(); 
}

class Professor 
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}

class Disciplina 
{
    public string NomeDaDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
}

//Restaurante
class Prato 
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Cardapio
{
    public List<Prato> ListaDePratos { get; set; } = new List<Prato>();
}

class Pedido 
{ 
    public Prato PratoPedido { get; set; }
    public int Quantidade { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> PedidosDaMesa { get; set; } = new List<Pedido>();
}

class Restaurante
{
    public Cardapio CardapioDoRestaurante { get; set; } = new Cardapio();
    public List<Mesa> MesasDoRestaurante { get; set; } = new List<Mesa>();
}//Conta Bancária
class Titular
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cpf { get; set; }
}

class Conta 
{
    public Titular Titular { get; set; }
    public string Agencia { get; set; }
    public string NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string InformacoesDetalhadas => $"Número da Conta: {this.NumeroDaConta} | Agência: {this.Agencia} | Titular: {this.Titular.Nome} | Saldo: R$ {this.Saldo}"; 
    
}

//Mercado
class Produto 
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
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 5;
            }
        } 
    }

    public int EmEstoque 
    {
        get => estoque; 
        
        set 
        {
            if (value > 0) 
            {
                estoque = value;
            }
            else
            {
                estoque = 0;
            }
        } 
    }

    public string DescricaoDoProduto => $"{this.Nome} da Marca {this.Marca} | Valor: R$ {this.preco} | Quantidade em Estoque: {this.estoque}";
}

//Escola
class Aluno 
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>(); 
}

class Professor 
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}

class Disciplina 
{
    public string NomeDaDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
}

//Restaurante
class Prato 
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Cardapio
{
    public List<Prato> ListaDePratos { get; set; } = new List<Prato>();
}

class Pedido 
{ 
    public Prato PratoPedido { get; set; }
    public int Quantidade { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> PedidosDaMesa { get; set; } = new List<Pedido>();
}

class Restaurante
{
    public Cardapio CardapioDoRestaurante { get; set; } = new Cardapio();
    public List<Mesa> MesasDoRestaurante { get; set; } = new List<Mesa>();
}
