// Screen Sound

using System.Net.Http.Headers;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDaBanda = new List<string> {"U2", "Calypso", "Prodigy", "Evanecence" };
Dictionary<string, List <int>> bandasRegistradas = new Dictionary<string, List <int>>();

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
        case 3: AvaliarUmaBanda();
            break;
        case 4: MediaBanda();
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
    //Console.WriteLine("Registro de Bandas");
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDaBanda.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirMenuDeOpções();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir todas as bandas registradas!!!");
    //Console.WriteLine("\nExibindo a lista de todas as bandas reigistradas:\n");
    //for (int i = 0; i < listadabanda.count; i++)
    //{
    //  console.writeline($"banda {listadabanda[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");    
    }
       

    Console.WriteLine("Digite qualquer tecla para voltar ao menu de opções!!!");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirMenuDeOpções();
    

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //Digite qual banda deseja avaliar
    //Verificar se a banda esta cadastrada
    //Se não estiver, volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Bandas!!!");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual nota quer atribuir a banda {nomeDaBanda}");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} atribuida a banda {nomeDaBanda} foi cadastrada com sucesso!!!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirLogo();
        ExibirMenuDeOpções();


    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não esta registrada!!!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!!!");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirMenuDeOpções();


    }

}

void MediaBanda()
{
     //Digite o nome da banda que deseja ver a média
     //Verificar se a banda esta cadastrada
     //Se não estiver, volta ao menu principal
     Console.Clear();
     Console.WriteLine("Digite o nome da banda que deseja ver a média!!!");
     string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> nota = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\n A média da banda digitada é {nomeDaBanda} é {nota.Average()}.");
 

    }
    else 
    {
        Console.WriteLine($"A banda {nomeDaBanda} não esta registrada!!! ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!!!");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirMenuDeOpções();
    }    
        

        
}





ExibirLogo();
ExibirMenuDeOpções();
