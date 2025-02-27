//Atividade 04 - Contrutor de Bandas

// Exercício 01 - Criar um construtor para a classe Titular, que inicialize todas suas propriedades.

//Exercício 02 - Criar um construtor para a classe Conta, que inicialize todas suas propriedades.

//Exercício 03 - Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

// Exercício 04 - Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

Titular titular1 = new Titular("Afonso", "123.456.789-10", "Rua das Caixas D'Água, 97.");

Conta conta1 = new Conta(titular1, 0000, 123456789, 1200, 2000);

Console.WriteLine(conta1.Informacoes);

CatalogoDeJogos favoritos = new CatalogoDeJogos();

favoritos.AdicionarJogoNovo("Kingdom Hearts III", "Action RPG", 2019);
favoritos.ListarCatalogo();
