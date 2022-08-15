//Armazenar os votos
int opcao = 0;
int chaves = 0;
int chiquinha = 0;
int quico = 0;
int nulo = 0;

do
{
    Console.WriteLine("As opções de votos são: ");
    Console.WriteLine("1. Candidato Chaves");
    Console.WriteLine("2. Candidata Chiquinha");
    Console.WriteLine("3. Candidato Quico");
    Console.WriteLine("4. Nulo/Branco");
    Console.WriteLine("5. Encerrar a Votação");
    Console.Write("Entre com o seu voto: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            chaves++;
            break;
        case 2:
            chiquinha++;
            break;
        case 3:
            quico++;
            break;
        case 4:
            nulo++;
            break;
        case 5:
            Console.WriteLine("Número de votos de cada candidato: ");
            Console.WriteLine("Candidato Chaves: " + chaves);
            Console.WriteLine("Candidata Chiquinha: " + chiquinha);
            Console.WriteLine("Candidato Quico: " + quico);
            Console.WriteLine("Candidato Nulo: " + nulo);
            Console.WriteLine("----------------------");

            int total = chaves + chiquinha + quico + nulo;
            double porcentagem = (nulo * 100) / total;

            Console.WriteLine("Porcentagem de votos Nulo: " + porcentagem + "%");
            Console.WriteLine("----------------------");

            Console.WriteLine("Porcentagem de votos Branco: " + porcentagem + "%");
            Console.WriteLine("----------------------");

            if (chaves > chiquinha && chaves > quico) {
                Console.WriteLine("O vencedor foi o Chaves");
            }
            else if (chiquinha > chaves && chiquinha > quico) {
                Console.WriteLine("A vencedora foi a Chiquinha");
            }
            else {
                Console.WriteLine("O vencedor foi o Quico");
            }
            break;
        default:
            Console.WriteLine("Escolha uma opção válida!");
            break;
    }
} while (opcao != 5);
