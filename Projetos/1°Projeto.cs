using static System.Console;

namespace AtividadeValendoNota
{
    class turma
    {
        public static void menuInicial(string[] opcoes)
        {
            foreach (string option in opcoes)
            {
                WriteLine(option);
            }
            WriteLine("Escolha a sua opção\n");
        }

        public static void Main(string[] args)
        {
            string[] opcoes = {
                "1 - Cadastrar Turma",
                "2 - Cadastrar aluno",
                "3 - Lista de aprovados",
                "4 - Lista de recuperação",
                "5 - Lista de reprovados",
                "6 - Lista geral",
                "7 - Editar Aluno",
                "8 - Editar Turma",
                "9 - Excluir Aluno",
                "10 - Excluir Turma",
                "11 - Gravar em um arquivo",
                "12 - Ler o arquivo",
                "13 - Sair"
            };
            int option = 0;
            while (true)
            {
                menuInicial(opcoes);
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine("Por favor, digite uma opção entre 1 e " + opcoes.Length);
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
                        editarAluno();
                        break;
                    case 8:
                        editarTurma();
                        break;
                    case 9:
                        excluirAluno();
                        break;
                    case 10:
                        excluirTurma();
                        break;
                    case 11:
                        gravarArquivo();
                        break;
                    case 12:
                        lerArquivo();
                        break;
                    case 13:
                        Environment.Exit(0);
                        ReadKey();
                        break;
                    default:
                        WriteLine("Por favor, Digite uma opção entre 1 e " + opcoes.Length);
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
                for (int i = 0; i < mediaCadaAluno.Count; i++)
                {
                    if (mediaCadaAluno[i] >= 7)
                    {
                        WriteLine($"Nome: {alunos[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
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
                for (int i = 0; i < mediaCadaAluno.Count; i++)
                {
                    if (mediaCadaAluno[i]> 5 && mediaCadaAluno[i] < 7)
                    {
                        WriteLine($"Nome: {alunos[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
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
                for (int i = 0; i < mediaCadaAluno.Count; i++)
                {
                    if (mediaCadaAluno[i] < 5)
                    {
                        WriteLine($"Nome: {alunos[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
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
                for (var i = 0; i < mediaCadaAluno.Count; i++)
                {
                    string cod = codigoAluno[i];
                    int indexTurma = codigoIdentificador.IndexOf(cod);
                    string nomeTurma = turmas[indexTurma];
                    WriteLine($"Turma: {nomeTurma} || Nome: {alunos[i]} || 1° Nota: {notas1[i]} || 2° Nota: {notas2[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
                }
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
            }
        }

        public static void editarAluno()
        {
            Clear();
            Write("EDITAR ALUNO: \n");
            WriteLine("");
            WriteLine("O que você deseja editar? \n1 - Somente o nome \n2 - Somente turma \n3 - Somente notas \n4 - Todos registros");
            string opcao = ReadLine();
            switch (opcao)
            {
                case "1":
                    editarNomeAluno();
                    break;
                case "2":
                    editarTurmaALuno();
                    break;
                case "3":
                    editarNotaAluno();
                    break;
                case "4":
                    editarTudo();
                    break;
            }
        }
        private static void editarNomeAluno()
        {
            Clear();
            Write("Digite o nome do aluno que deseja editar: ");
            string nome = ReadLine();
            int index = alunos.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine($"O aluno a ser editado é o {alunos[index]}.\n");
                Write("Regite o nome: ");
                string novoNome = ReadLine();
                var igual = alunos.Any(x => x == novoNome);
                if (igual == true)
                {
                    WriteLine("Este nome já está cadastrado. Tente novamente.");
                    Clear();
                    return;
                }
                else
                {
                    alunos[index] = novoNome;
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Nome alterado com sucesso!");
                    ResetColor();
                    Clear();
                    return;
                }
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Este nome não consta em nossos registros!");
                ResetColor();
                Clear();
                return;
            }
            
        }
        
        private static void editarTurmaAluno()
        {
            Clear();
            Write("Digite o nome da turma do aluno que deseja editar: ");
            string turma = ReadLine();
            int index = turmas.IndexOf(turma);
            WriteLine("");
            Write("Digite o identificador da turma: ");
            string idAt = ReadLine();
            int idx = codigoIdentificador.IndexOf(idAt);
            if (index >= 0)
            {
                WriteLine($"A turma do aluno atual é: {turma[index]} e o código identificador desta turma é o: {codigoIdentificador[idx]}\n");
                Write("Digite a qual turma este aluno irá pertencer: ");
                string novaTurma = ReadLine();
                WriteLine("Digite o código identificador desta turma: ");
                if
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Esta turma não consta em nossos registros!");
                ResetColor();
                Clear();
                return;
            }
        }

        private static void editarTurma()
        {
            Clear();
            Write("DIGITE O NOME DA TURMA QUE VOCÊ DESEJA EDITAR:\n");
            string nome = ReadLine();
            int index = turmas.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine($"O aluno a ser editado é o {turmas[index]}.\n");
                Write("Regite o nome: ");
                string novoNome = ReadLine();
                var igual = turmas.Any(x => x == novoNome);
                if (igual == true)
                {
                    WriteLine("Este nome já está cadastrado. Tente novamente.");
                    return;
                }
                else
                {
                    turmas[index] = novoNome;
                }
            }
            else
            {
                WriteLine("Este nome não existe nos registros.");
            }
            Clear();
        }

        private static void excluirAluno()
        {

        }
        private static void gravarArquivo()
        {
            Clear();
            WriteLine("GRAVAR ARQUIVO:\n");
            try
            {
                StreamWriter dadosnomes;
                string arq = @"C:\Nomes\nomes.txt";
                dadosnomes = File.CreateText(arq);
                for (var i = 0; i < alunos.Count; i++)
                {
                    string cod = codigoAluno[i];
                    int indexTurma = codigoIdentificador.IndexOf(cod);
                    string nomeTurma = turmas[indexTurma];
                    dadosnomes.WriteLine($"Turma: {nomeTurma} || Nome: {alunos[i]} || 1° Nota: {notas1[i]} || 2° Nota: {notas2[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
                }
                dadosnomes.Close();
            }
            catch (Exception e)
            {
                WriteLine($"{e.Message}");
            }
            finally
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("<<<<<< DADOS GRAVADOS COM SUCESSO! >>>>>>");
                ResetColor();

            }
            Clear();
        }

        private static void lerArquivo()
        {
            Clear();
            WriteLine("LER ARQUIVO:\n");
            var nome = File.ReadAllLines(@"C:\Nomes\nomes.txt");
            for (int i = 0; i < nome.Length; i++)
            {
                alunos.Add(nome[i]);
            }
            ForegroundColor = ConsoleColor.Green;
            WriteLine("<<<<<<< LEITURA REALIZADA COM SUCESSO! >>>>>>>");
            ResetColor();
            Clear();
        }
    }

}
