using System;

namespace md04_CadernoExercicios_05
{
    class Program
    {
        static void Main(string[] args)
        /*
         5. Faça um algoritmo que calcule a média de salários de uma empresa,
            pedindo ao usuário a quantidade de funcionários e o salário de cada
            funcionário. Exiba a média salarial, o salário mais alto e o salário mais baixo.
         */
        {
            double qtdFuncionarios = 0, i = 1, media, salMaior = 0, salMenor=0 , salarios, somaSal = 0;
            Console.WriteLine("Por favor. informe a quantidade de funcionários você deseja calcular:");
            qtdFuncionarios = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite o salário do " + i + "° funcionário;");
                salarios = Convert.ToDouble(Console.ReadLine());
                if (salMenor ==0)
                {
                    salMenor = salarios;
                }
                somaSal = somaSal + salarios;

                if (salarios > salMaior)
                {
                    salMaior = salarios;
                }
                else if (salarios < salMenor)
                {
                    salMenor = salarios;
                }
                i++;
            } while (i <= qtdFuncionarios);
            i--;
            media = somaSal / i;

            Console.WriteLine("\nMédia Salarial R$ {0}\nSalário mais alto R$ {1}\nSalário mais baixo R$ {2}",
                media.ToString("0,0"),salMaior.ToString("0,0"),salMenor.ToString("0,0"));
        }
    }
}
