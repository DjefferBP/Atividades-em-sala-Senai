using static System.Console;
using System;

namespace AtividadeValendoNota
{
    class turma
    {
        public static void printMenu(string[] options)
        {
            foreach (string option in options)
            {
                WriteLine(option);
            }
            WriteLine("Escolha a sua opção\n");
        }

        public static void Main(string[] args)
        {
            string[] options = {
                "1 - Cadastrar Turma",
                "2 - Cadastrar aluno",
                "3 - Lista de aprovados",
                "4 - Lista de recuperação",
                "5 - Lista de recuperação",
                "6 - Lista geral",
                "7 - Sair"
            };
            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!! Tente novamente");
                    continue;
                }
                switch (option)
                {

                    case 1:
                        cadastrarTurma();
                        break;
                    case 2:
                        cadastarAluno();
                        break;
                    case 3:
                        listaDeAprovados();
                        break;
                    case 4:
                        listaDeRecuperacao();
                        break;
                    case 5:
                        listaDeReprovados();
                        break;
                    case 6:
                        listaGeral();
                        break;
                    case 7:
                        Environment.Exit(0);
                        ReadKey();
                        break;
                    default:
                        WriteLine("Por favor, Digite uma opção entre 1 e " + options.Length);
                        break;
                }

            }
        }
        static List<string> codigoAluno = new List<string>();
        static List<string> alunos = new List<string>();
        static List<string> turmas = new List<string>();
        static List<string> codigoIdentificador = new List<string>();
        static List<double> notas1 = new List<double>();
        static List<double> notas2 = new List<double>();
        static List<double> mediaCadaAluno = new List<double>();

        private static void cadastrarTurma()
        {
            while (true)
            {
                Clear();
                WriteLine("CADASTRO DE TURMAS\n");
                WriteLine("Digite a turma.");
                string turma = ReadLine();
                var repetido = turmas.Any(x => x == (turma));
                if (repetido == true)
                {
                    WriteLine("Aluno já cadastrado, Refaça a operação\n");
                    return;
                }
                else
                {
                    turmas.Add(turma);

                }
                WriteLine("Digite seu código identificador.");
                string identificador = ReadLine();
                var repetido1 = codigoIdentificador.Any(codigo => codigo == (identificador));
                if (repetido1 == true)
                {
                    WriteLine("O código identificador inserido já pertence à alguma turma, cadastre outro código.");

                }
                else
                {
                    codigoIdentificador.Add(identificador);
                }

                while (true)
                {
                    WriteLine("\nDeseja Cadastrar mais alguma turma? (s)/(n)");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        break;
                    }
                    else if (opcao == "n")
                    {
                        Clear();
                        return;
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida.");
                    }
                }
            }

        }
        private static void cadastarAluno()
        {
            while (true)
            {
                Clear();
                WriteLine("CADASTRO DE ALUNOS E SUAS NOTAS\n");

                WriteLine("Digite o nome do aluno.");
                string nome = ReadLine();
                var repetido = alunos.Any(estudante => estudante == (nome));
                if (repetido == true)
                {
                    WriteLine("Este nome já existe no sistema. Tente mudar o nome ou cadastrar outro.");
                }
                else
                {
                    alunos.Add(nome);
                }

                WriteLine("Digite a 1ª nota do aluno");
                try
                {
                    notas1.Add(Convert.ToDouble(ReadLine()));
                }
                catch (System.FormatException)
                {
                    WriteLine("Erro de digitação, por favor refaça a operação");
                    return;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!! Tente novamente");
                    return;
                }
                WriteLine();

                WriteLine("Digite a 2ª nota do aluno");
                try
                {
                    notas2.Add(Convert.ToDouble(ReadLine()));
                }
                catch (System.FormatException)
                {
                    WriteLine("Erro de digitação, por favor refaça a operação");
                    return;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!! Tente novamente");
                    return;
                }

                WriteLine("Digite o código identificador da turma do aluno:");
                string codTurma = ReadLine();

                if (!codigoIdentificador.Contains(codTurma))
                {
                    WriteLine("Código de turma inválido! Refaça a operação.");
                    return;
                }
                codigoAluno.Add(codTurma);

                int i = alunos.Count - 1;
                double mediaAlunos = (notas1[i] + notas2[i]) / 2;
                mediaCadaAluno.Add(mediaAlunos);
                while (true)
                {
                    WriteLine("Deseja adicionar mais algum aluno? (s) / (n)");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        break;
                    }
                    else if (opcao == "n")
                    {
                        Clear();
                        return;
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida.");
                    }
                }

            }
        }

        private static void listaDeAprovados()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Clear();
                WriteLine("APROVADOS:\n");
                foreach (var item in mediaCadaAluno)
                {
                    if (item >= 7)
                    {
                        int idx = mediaCadaAluno.IndexOf(item);
                        WriteLine($"Nome: {alunos[idx]} || Média: {Math.Round(item, 1)}");
                    }
                }
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
            }
        }

        private static void listaDeRecuperacao()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Clear();
                WriteLine("RECUPERAÇÃO:\n");
                foreach (var item in mediaCadaAluno)
                {
                    if (item < 7 && item >= 5)
                    {
                        int idx = mediaCadaAluno.IndexOf(item);
                        WriteLine($"Nome: {alunos[idx]} || Média: {Math.Round(item, 1)}");
                    }
                }
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
            }
        }

        private static void listaDeReprovados()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Clear();
                WriteLine("REPROVADOS:\n");
                foreach (var item in mediaCadaAluno)
                {
                    if (item < 5)
                    {
                        int idx = mediaCadaAluno.IndexOf(item);
                        WriteLine($"Nome: {alunos[idx]} || Média: {Math.Round(item, 1)}");
                    }
                }
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
            }
        }

        private static void listaGeral()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Clear();
                WriteLine("TODOS ALUNOS:\n");
                for (var idx = 0; idx < mediaCadaAluno.Count; idx++)
                {
                    string cod = codigoAluno[idx];
                    int indexTurma = codigoIdentificador.IndexOf(cod);
                    string nomeTurma = turmas[indexTurma];
                    WriteLine($"Turma: {nomeTurma} || Nome: {alunos[idx]} || 1° Nota: {notas1[idx]} || 2° Nota: {notas2[idx]} || Média: {Math.Round(mediaCadaAluno[idx], 1)}");
                }
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
            }
        }
    }

}
