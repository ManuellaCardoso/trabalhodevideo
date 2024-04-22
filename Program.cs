using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Solicita o nome da pessoa
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            // Solicita a idade da pessoa
            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            // Solicita a altura da pessoa em metros
            Console.Write("Digite a altura da pessoa em metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Solicita o peso da pessoa em quilogramas
            Console.Write("Digite o peso da pessoa em quilogramas: ");
            double peso = double.Parse(Console.ReadLine());

            // Calcula o IMC
            double imc = peso / (altura * altura);

            // Determina a categoria de IMC
            string categoriaIMC;
            if (imc < 18.5)
                categoriaIMC = "Abaixo do peso";
            else if (imc < 25)
                categoriaIMC = "Normal";
            else if (imc < 30)
                categoriaIMC = "Sobrepeso";
            else
                categoriaIMC = "Obeso";

            // Determina a faixa etária da pessoa
            string faixaEtaria;
            if (idade <= 12)
                faixaEtaria = "Criança";
            else if (idade <= 18)
                faixaEtaria = "Adolescente";
            else if (idade <= 59)
                faixaEtaria = "Adulto";
            else
                faixaEtaria = "Idoso";

            // Imprime o relatório final
            Console.WriteLine("\nRelatório:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} - {categoriaIMC}");
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

        // Pergunta ao usuário se deseja gerar outro relatório
            Console.Write("\nDeseja gerar um novo relatório? (s-sim / n-não): ");
        } while (Console.ReadLine().ToLower() == "s");
    }
}

