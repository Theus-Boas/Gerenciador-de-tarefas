using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            teste t = new teste();
            int opcao = 0;
            int sair = 404;
            int menu = 1;
            List<string> domingo = new List<string>() { };
            List<string> segunda = new List<string>() { };
            List<string> terca = new List<string>() { };
            List<string> quarta = new List<string>() { };
            List<string> quinta = new List<string>() { };
            List<string> sexta = new List<string>() { };
            List<string> sabado = new List<string>() { };
            while (menu != opcao)
            {
                Console.Clear();
                Console.WriteLine("-- Seja Bem-Vindo (a) ao seu gerenciador de listas detarefas --\n");
                Console.WriteLine("[1] -> Domingo");
                Console.WriteLine("[2] -> Segunda-Feira");
                Console.WriteLine("[3] -> Terça-Feira");
                Console.WriteLine("[4] -> Quarta-Feira");
                Console.WriteLine("[5] -> Quinta-Feira");
                Console.WriteLine("[6] -> Sexta-Feira");
                Console.WriteLine("[7] -> Sábado");
                Console.WriteLine("\n[0] -> Fechar programa");
                Console.WriteLine("\nQual lista gostaria de verificar hoje:");
                int dia = int.Parse(Console.ReadLine());
                switch (dia)
                {
                    case 1:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Domingo --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {domingo.Count} tarefas\n\n");
                                for (int z = 0; z < domingo.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {domingo[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(domingo);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < domingo.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {domingo[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < domingo.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {domingo[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, domingo);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {domingo.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(domingo);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 2:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Segunda-Feira --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {segunda.Count} tarefas\n\n");
                                for (int z = 0; z < segunda.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {segunda[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(segunda);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < segunda.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {segunda[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar de sua lista? \n");
                                Console.WriteLine("Escolha: ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                Console.Clear();
                                Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove}] - {segunda[remove]}? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste1 = char.Parse(Console.ReadLine());
                                if (teste1 == 's')
                                {
                                    t.Teste1(remove, segunda);
                                }
                                else
                                {
                                    teste1 = 'n';
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {segunda.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(segunda);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 3:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Terça-Feira --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {terca.Count} tarefas\n\n");
                                for (int z = 0; z < terca.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {terca[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(terca);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < terca.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {terca[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < terca.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {terca[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, terca);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {terca.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(terca);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 4:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Quarta-Feira --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {quarta.Count} tarefas\n\n");
                                for (int z = 0; z < quarta.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {quarta[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(quarta);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < quarta.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {quarta[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < quarta.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {quarta[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, quarta);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {quarta.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(quarta);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 5:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Quinta-Feira --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {quinta.Count} tarefas\n\n");
                                for (int z = 0; z < quinta.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {quinta[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(quinta);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < quinta.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {quinta[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < quinta.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {quinta[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, quinta);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {quinta.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(quinta);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 6:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Sexta-Feira --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {sexta.Count} tarefas\n\n");
                                for (int z = 0; z < sexta.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {sexta[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(sexta);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < sexta.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {sexta[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < sexta.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {sexta[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, sexta);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {sexta.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(sexta);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 7:
                        opcao = 0;
                        while (opcao != sair)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Sábado --\n");
                            Console.WriteLine("Digite:\n[1] -> Minhas tabelas");
                            Console.WriteLine("[2] -> Adicionar uma nova tarefa");
                            Console.WriteLine("[3] -> Apagar uma tarefa");
                            Console.WriteLine("[4] -> Apagar todas as tarefas");
                            Console.WriteLine("[404] -> Para voltar ao menu principal\n");
                            Console.WriteLine("Escolha: ");
                            opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Sua tabela aprensenta um total de: {sabado.Count} tarefas\n\n");
                                for (int z = 0; z < sabado.Count; z++)
                                {
                                    Console.WriteLine($"[{z + 1}] - {sabado[z]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Precione qualque tecla para volatar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcao == 2)
                            {
                                char teste = '1';
                                while (teste == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine("-- Adição de novas tarefas --\n");
                                    Console.WriteLine("[1] -> Adicionar nova tarefa");
                                    Console.WriteLine("[2] -> Voltar ao menu\n");
                                    Console.WriteLine("Escolha: ");
                                    teste = char.Parse(Console.ReadLine());
                                    if (teste == '1')
                                    {
                                        t.Teste(sabado);
                                    }

                                    else
                                    {
                                        teste = '2';
                                    }
                                }
                            }
                            else if (opcao == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar uma tarefa através do seu indice --\n");
                                for (int i = 0; i < sabado.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] - {sabado[i]}");
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.Write("Qual tarefa deseja retirar? ");
                                int remove = int.Parse(Console.ReadLine()) - 1;
                                if (remove >= 0 && remove < sabado.Count)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Certeza que deseja apagar a tarefa:\n[{remove + 1}] - {sabado[remove]}? (s/n)\n");
                                    Console.WriteLine("Escolha: ");
                                    char teste1 = char.Parse(Console.ReadLine());
                                    if (teste1 == 's')
                                    {
                                        t.Teste1(remove, sabado);
                                    }
                                    else
                                    {
                                        teste1 = 'n';
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Essa tarefa não existe na lista!");
                                }
                            }
                            else if (opcao == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("-- Apagar todas as tarefas dessa lista --\n");
                                Console.WriteLine($"Você deseja apagar todas as {sabado.Count} tarefas presentes nessa lista? (s/n)\n");
                                Console.WriteLine("Escolha: ");
                                char teste2 = char.Parse(Console.ReadLine());
                                if (teste2 == 's')
                                {
                                    t.Teste2(sabado);
                                }
                                else
                                {
                                    teste2 = 'n';
                                }
                            }
                        }
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Tem total certeza que deseja sair do programa? (s/n)");
                        char verificar = char.Parse(Console.ReadLine());
                        if (verificar == 's')
                        {
                            opcao = 1;
                        }
                        break;
                 
                }
            }
        }
    }
}

