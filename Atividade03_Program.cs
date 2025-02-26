//Atividade 03 - Integrando Classes e Definindo Relacionamentos

//Exercício 01 - Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

//Exercício 02 - Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

//Exercício 03 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

//Exercício 04 - Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

//Exercício 05 - Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

Titular titular1 = new Titular();
titular1.Nome = "Francisco";
titular1.Endereco = "Rua Nova Vida, 462";
titular1.Cpf = "123.456.789-10";

Conta conta1 = new Conta();
conta1.Titular = titular1;
conta1.Agencia = "Nubank";
conta1.NumeroDaConta = "10987654321";
conta1.Saldo = 1000;
conta1.Limite = 2000;

Console.WriteLine("Informações da Conta:");
Console.WriteLine($"Nome: {conta1.Titular.Nome}");
Console.WriteLine($"Endereço: {conta1.Titular.Endereco}");
Console.WriteLine($"CPF: {conta1.Titular.Cpf}\n");

Produto produto1 = new Produto();
produto1.Nome = "Leite Consensado - Moça";
produto1.Marca = "Nestlé";
produto1.Preco = 8;
produto1.EmEstoque = 20;

Console.WriteLine(produto1.DescricaoDoProduto);
