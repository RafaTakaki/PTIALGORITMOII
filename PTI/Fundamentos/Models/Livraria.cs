namespace DesafioFundamentos.Models
{
    public class Livraria
    {
        private List<string[]> livros = new List<string[]>();
        private int contadorId = 1;

        public Livraria(int id, string nome, string autor, string genero, decimal valor, int estoque)
        {
            
        }

        public void AdicionarLivro()
        {
        

            Console.WriteLine("Informe o nome do Livro:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o valor:");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o autor(a):");
            string autor = Console.ReadLine();

            Console.WriteLine("Informe o Gênero:");
            string genero = Console.ReadLine();

            int estoque = 0;

            string[] livro = new string[6];
            livro[0] = contadorId.ToString();  
            livro[1] = nome;                   
            livro[2] = autor;                  
            livro[3] = genero;                
            livro[4] = valor.ToString("F2");   
            livro[5] = estoque.ToString();   

            livros.Add(livro);
        
            contadorId++;

            Console.WriteLine("Livro adicionado com sucesso!\n");

        }
    
        public void Removerlivros()

        {
        Console.WriteLine("Digite o nome do livro para remover:");

             string nomeLivroParaRemover = Console.ReadLine();
             string[] livroParaRemover = livros.Find(livro => livro[1].Equals(nomeLivroParaRemover, StringComparison.OrdinalIgnoreCase));

             if (livroParaRemover != null)
             {
                    
                 livros.Remove(livroParaRemover);

                 Console.WriteLine($"O livro {livroParaRemover} foi removido ");
             }
             else
             {
                 Console.WriteLine("Desculpe, esse livro não foi localizado. Confira se digitou o nome corretamente");
             }
         }

        public void ListarLivros()
{
    if (livros.Any())
    {
        Console.WriteLine("Os livros são:");

        // Usando um loop foreach para iterar sobre a lista de livros
        foreach (var livro in livros)
        {
            // Exibindo as informações do livro
            Console.WriteLine($"ID: {livro[0]}");
            Console.WriteLine($"Nome: {livro[1]}");
            Console.WriteLine($"Autor: {livro[2]}");
            Console.WriteLine($"Gênero: {livro[3]}");
            Console.WriteLine($"Valor: R${livro[4]}");
            Console.WriteLine($"Estoque: {livro[5]}");
            Console.WriteLine(); // Linha em branco para separação
        }
    }
    else
    {
        Console.WriteLine("Não há livros cadastrados.");
             }
         }
     }
 }
