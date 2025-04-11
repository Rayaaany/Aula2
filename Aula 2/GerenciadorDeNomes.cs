using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    public class GerenciadorDeNomes
    {
        private readonly string _caminhoArquivo;

        public GerenciadorDeNomes(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        public void AdicionarNome()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            string dataHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string linha = $"{dataHora} - {nome}";
            File.AppendAllText(_caminhoArquivo, linha + Environment.NewLine);

            Console.WriteLine("Nome salvo com sucesso!");
        }

        public void ListarNomes()
        {
            Console.WriteLine("\n--- Lista de nomes persistidos ---");

            if (File.Exists(_caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(_caminhoArquivo);

                foreach (string linha in linhas)
                {
                    Console.WriteLine("- " + linha);
                }
            }
            else
            {
                Console.WriteLine("Nenhum nome foi salvo ainda.");
            }
        }
    }
}
