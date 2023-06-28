// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDaBanda = new List<string> {"U2", "Calypso", "Prodigy", "Evanecence" };

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirMenuDeOpções()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 0 para SAIR");

    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Opção Escolhida: " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Opção Escolhida: " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("Obrigado por usar nosso sistema.");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDaBanda.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirMenuDeOpções();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("\nExibindo a lista de todas as bandas reigistradas:\n");
    //for (int i = 0; i < listadabanda.count; i++)
    //{
    //  console.writeline($"banda {listadabanda[i]}");
    //}

    foreach (string banda in listaDaBanda)
    {
        Console.WriteLine($"Banda {banda}");    
    }
       

    Console.WriteLine("Digite qualquer tecla para voltar ao menu de opções!!!");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirMenuDeOpções();
    

}

ExibirLogo();
ExibirMenuDeOpções();
