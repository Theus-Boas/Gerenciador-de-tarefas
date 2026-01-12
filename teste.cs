using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_tarefas
{
    public class teste
    {
            public void Teste(List<string> tarefas)
            {
                string newtask;
                Console.Clear();
                Console.WriteLine("Qual o nome da nova Tarefa que deseja relizar? ");
                newtask = Console.ReadLine();
                tarefas.Add(newtask);
                Console.WriteLine("\nTarefa adicionada com sucesso!!\n");
                Console.WriteLine("Precione qualquer tecla para voltar ao submenu...");
                Console.ReadKey();
            }
            public void Teste1(int remove, List<string> tarefas)
            {
                tarefas.RemoveAt(remove);
                Console.WriteLine("\nTarefa removida com sucesso!!\n\n");
                Console.WriteLine("Precione qualquer tecla para voltar ao submenu...");
                Console.ReadKey();
            }
            public void Teste2(List<string> tarefas)
            {
                tarefas.Clear();
                Console.WriteLine("\ntodas as tarefas presentes dentro dessa tabela foram apagados com sucesso!!\n");
                Console.WriteLine("Precisone qualquer tecla para retornar ao menu principal...");
                Console.ReadKey();
            }

    }
}
