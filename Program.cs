using System;

namespace AulaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Criação de um objeto p, do tipo da classe Pessoa
            // Pessoa p = new Pessoa();

            // // Exibindo na tela informações do objeto p ,
            // // realizando uma chamada do método ToString
            // Console.WriteLine(p.ToString());

            // // Atribuindo um nome ao objeto p, por meio da 
            // // propriedade Nome.
            // p.Nome = "Tiago";

            // // Exibindo na tela informações do objeto p,
            // // após a atribuição do nome
            // Console.WriteLine(p);
            // Console.ReadKey();

            // Entrada de dados usando variáveis auxiliares
            Console.Write("Digite o nome da pessoa: "); 
            string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ",n); 
            int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}: ",n); 
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correspondente ao sexo (F/M): "); 
            char s = char.Parse(Console.ReadLine());

            // Criando um objeto, usando o construtor com parâmetros
            Pessoa pessoa = new Pessoa(n, i, a, s);

            // Exibindo os dados da pessoa cadastrada
            Console.WriteLine("\n\n**** Dados da Pessoa ****\n");
            Console.WriteLine(pessoa.ToString());

            // Exibindo o resultado do calculo do peso ideal
            Console.WriteLine(" Peso Ideal: {0}", pessoa.calcularPesoIdeal());

            Console.ReadKey();

        }
    }
}
