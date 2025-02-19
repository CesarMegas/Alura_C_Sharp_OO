//Atividade 02 - Métodos de Acesso e Propriedades

//Exercício 01 - Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.

//Exercício 02 - Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

// Exercício 03 - Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

//Exercício 04 - Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.

ContaBancaria novaConta = new ContaBancaria();
novaConta.NumeroIndicador = 0987654321;
novaConta.Titular = "Irineu";
novaConta.Saldo = 1900;
novaConta.Senha = "senha321";
novaConta.ExibirInformacoes();

ModelaCarro novoCarro = new ModelaCarro();
novoCarro.Modelo = "Buggati Divo";
novoCarro.Ano = 2020;
novoCarro.Fabricante = "Buggati";
Console.WriteLine(novoCarro.DescricaoDetalhada);

Produto novoProduto = new Produto();
novoProduto.Nome = "Nescau 2.0 400g";
novoProduto.Marca = "Nestlé";
novoProduto.Preco = 8.50;
novoProduto.Estoque = 20;
Console.WriteLine(novoProduto.InformacaoDetalhadaDoProduto);
