using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de Vendas!");

Livraria ly = new Livraria(0, "0", "0", "0", 0, 0 );

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Novo Livro");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Remover Livros");
    Console.WriteLine("4 - Entrada de Estoque");
    Console.WriteLine("5 - Saída de Estoque");
    Console.WriteLine("0 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            ly.AdicionarLivro();
            
            break;

        case "2":
            ly.ListarLivros();
            break;

        case "3":
            ly.Removerlivros();
            break;

        case "4":
            ly.Removerlivros();
            break;
        
        case "5":
            ly.Removerlivros();
            break;

        case "0":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
