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
            Console.Clear();
            Console.WriteLine("Informe o nome do Livro:");
            string nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Informe o valor:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe o autor(a):");
            string autor = Console.ReadLine();
            Console.Clear();

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
    
        public void RemoverLivros()

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

                foreach (var livro in livros)
                {
            
                    Console.WriteLine($"ID: {livro[0]}");
                    Console.WriteLine($"Nome: {livro[1]}");
                    Console.WriteLine($"Autor: {livro[2]}");
                    Console.WriteLine($"Gênero: {livro[3]}");
                    Console.WriteLine($"Valor: R${livro[4]}");
                    Console.WriteLine($"Estoque: {livro[5]}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não há livros cadastrados.");
            }
        }  
        public void EntradaEstoque()
        {
            Console.WriteLine("Digite o nome do livro para lançar estoque:");
            string livroParaLancarEstoque = Console.ReadLine();
            string[] estoqueParaAdcionar = livros.Find(livro => livro[1].Equals(livroParaLancarEstoque, StringComparison.OrdinalIgnoreCase));
            
            if (estoqueParaAdcionar != null)
             {
                Console.WriteLine("A quantidade de livros no estoques é: " + estoqueParaAdcionar[5]);
                Console.WriteLine("Digite a quantidade para lançar estoque:");
                int estoqueLancado = Convert.ToInt32(Console.ReadLine());
                
                int estoqueAtual = Convert.ToInt32(estoqueParaAdcionar[5]);
                estoqueAtual += estoqueLancado; 
                estoqueParaAdcionar[5] = estoqueAtual.ToString();
                
                Console.WriteLine("Quantidade Lançada!\nO novo estoque é: " + estoqueParaAdcionar[5]);

             }
             else 
             {
                Console.WriteLine("Livro não encontrado no sistema.");
             }
        }
        public void SaidaEstoque()
        {
            Console.WriteLine("Digite o nome do livro para lançar estoque:");
            string livroParaLancarEstoque = Console.ReadLine();
            string[] estoqueParaDeduzir = livros.Find(livro => livro[1].Equals(livroParaLancarEstoque, StringComparison.OrdinalIgnoreCase));
            
            if (estoqueParaDeduzir != null)
             {
                Console.WriteLine("A quantidade de livros no estoques é: " + estoqueParaDeduzir[5]);
                Console.WriteLine("Digite a quantidade para lançar estoque:");
                int estoqueLancado = Convert.ToInt32(Console.ReadLine());
                
                int estoqueAtual = Convert.ToInt32(estoqueParaDeduzir[5]);
                estoqueAtual -= estoqueLancado;
                estoqueParaDeduzir[5] = estoqueAtual.ToString();

                Console.WriteLine("Quantidade Lançada!\nO novo estoque é: " + estoqueParaDeduzir[5]);
                
             }
             else 
             {
                Console.WriteLine("Livro não encontrado no sistema.");
             }
        }
    }
 }
