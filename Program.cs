// SEMANA 5
string mensagemDeProjeto = "Projeto Semana 5";
Console.WriteLine(mensagemDeProjeto);


void ExibirLogo()
{
Console.WriteLine(@"

░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝
");
Console.WriteLine("projeto Comex");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar produto");
    Console.WriteLine("Digite 2 para registrar categoria do produto");
    Console.WriteLine("Digite 3 para registrar Cliente");
    Console.WriteLine("Digite 4 para registrar Pedido");
    Console.WriteLine("Digite 5 Registrar item do pedido");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);




    

    Produto produto1 = new Produto();

    produto1.nomeDoProduto = "Super Candida";
    produto1.descricaoDoproduto = "Clorificado";
    produto1.valorProdutoDoProduto = 35.00
    produto1.QuantidadeDoProduto = 25





}