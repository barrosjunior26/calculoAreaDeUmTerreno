namespace Exercicio28
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*28) Faça um programa que leia a largura e o comprimento de um terreno
            retangular, calculando e mostrando a sua área em m². O programa também
            deve mostrar a classificação desse terreno, de acordo com a lista abaixo:
            -Abaixo de 100m² = TERRENO POPULAR
            - Entre 100m² e 500m² = TERRENO MASTER
            - Acima de 500m² = TERRENO VIP*/

            //Declaração de variáveis
            int escolha = 0;

            do
            {
                //Solicitando ao usuário a entrada de dados
                Console.Write("Informe a largura: ");
                double largura = double.Parse(Console.ReadLine());
                Console.Write("Agora informe o comprimento: ");
                double comprimento = double.Parse(Console.ReadLine());

                /*Processamento dos dados
                 * A = Corresponde a área
                 * B = corresponde ao lado B
                 * C = corresponte ao lado C*/
                double A = largura * comprimento;

                //Classificação do terreno
                //100² para um terro do tipo POPULAR
                if (A < 100)
                {
                    Console.WriteLine($"Chegamos a conclusão que seu terreno, possui o total de {A} m².\nTerreno com classificação: POPULAR.");
                    //De 100m² a 500m²para um terreno do tipo MASTER
                }
                else if (A >= 100 && A <= 500)
                {
                    Console.WriteLine($"Chegamos a conclusão que seu terreno, possui o total de {A} m².\nTerreno com classificação: MASTER.");
                }
                //Acima de 500m² para um terreno do tipo VIP
                else
                {
                    Console.WriteLine($"Chegamos a conclusão que seu terreno possui o total de {A} m².\nTerreno com classificação: VIP");
                }
                Console.Write("1 - Para nova operação ou 0 para SAIR do sistema: ");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("Encerrando o sistema...");
            } while (escolha != 0);


        }
    }
}