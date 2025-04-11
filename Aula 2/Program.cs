using Aula_2;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "dados.txt";
        GerenciadorDeNomes gerenciador = new GerenciadorDeNomes(caminhoArquivo);

        Console.WriteLine("=== EXEMPLO DE PERSISTÊNCIA DE DADOS ===");

        while (true)
        {
            Console.WriteLine("\n1 - Adicionar nome");
            Console.WriteLine("2 - Listar nomes");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    gerenciador.AdicionarNome();
                    break;
                case "2":
                    gerenciador.ListarNomes();
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}

