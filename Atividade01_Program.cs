//Atividade 01 - Classe e Método no C#

//Exercício 01 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

// Exercício 02 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

// Exercício 03 - Desenvolver um método da classe Conta que exibe suas informações.

// Exercício 04 - Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

ContaBancaria novaConta = new ContaBancaria();
novaConta.numeroIndicador = 123456789;
novaConta.titular = "Astolfo";
novaConta.saldo = 1200;
novaConta.senha = "senha123";

novaConta.ExibirInformacoes();
