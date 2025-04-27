using System;
using System.Reflection;
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
                        cadastrarAluno();
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

                string novaTurma = "";
                do
                {
                    WriteLine("Digite a turma:");
                    novaTurma = ReadLine();
                    if (string.IsNullOrWhiteSpace(novaTurma))
                    {
                        WriteLine("O nome da turma não pode ser vazio. Por favor, insira um valor válido.");
                    }
                } while (string.IsNullOrWhiteSpace(novaTurma));


                var repetido = turmas.Any(x => x == (novaTurma));
                if (repetido == true)
                {
                    WriteLine("Turma já cadastrada, Refaça a operação\n");
                    return;
                }
                else
                {
                    turmas.Add(novaTurma);
                }
                string identificador = " ";
                do
                {
                    WriteLine("Digite o código identificador da turma:");
                    identificador = ReadLine();
                    if (string.IsNullOrWhiteSpace(identificador))
                    {
                        WriteLine("O código identificador não pode ser vazio. Por favor, insira um valor válido.");
                    }
                } while (string.IsNullOrWhiteSpace(identificador));
                var repetido1 = codigoIdentificador.Any(codigo => codigo == (identificador));
                if (repetido1 == true)
                {
                    WriteLine("O código identificador inserido já pertence à alguma turma, cadastre outro código.");
                    turmas.Remove(novaTurma);
                    return;
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
        private static void cadastrarAluno()
        {
            while (true)
            {
                Clear();
                WriteLine("CADASTRO DE ALUNOS E SUAS NOTAS\n");

                string nome = "";
                do
                {
                    Write("Digite o nome do aluno: ");
                    nome = ReadLine();
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        WriteLine("O nome do aluno não pode ser vazio. Por favor, insira um valor válido.");
                        ReadKey();
                        Clear();
                        return;
                    }
                } while (string.IsNullOrWhiteSpace(nome));
                var repetido = alunos.Any(estudante => estudante == (nome));
                if (repetido == true)
                {
                    WriteLine("Este nome já existe no sistema. Tente mudar o nome ou cadastrar outro.");
                    ReadKey();
                    Clear();
                    return;
                }
                else
                {
                    alunos.Add(nome);
                }
                double verif, verif1;
                double nota1 = 0, nota2 = 0;
                Write("\nDigite a 1ª nota do aluno: ");
                try
                {
                    do
                    {
                        verif = Convert.ToDouble(ReadLine());
                        if (verif < 0 || verif > 10)
                        {
                            WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                            continue;
                        }
                        nota1 = verif;
                        break;
                    } while (true);
                }
                catch (System.FormatException)
                {
                    WriteLine("Erro de digitação, por favor refaça a operação");
                    alunos.Remove(nome);
                    return;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!! Tente novamente");
                    alunos.Remove(nome);
                    return;
                }
                notas1.Add(nota1);
                WriteLine();

                Write("\nDigite a 2ª nota do aluno: ");
                try
                {
                    do
                    {
                        verif1 = Convert.ToDouble(ReadLine());
                        if (verif1 < 0 || verif1 > 10)
                        {
                            WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                            continue;
                        }

                        nota2 = verif1;
                        break;
                    } while (true);
                }
                catch (System.FormatException)
                {
                    WriteLine("Erro de digitação, por favor refaça a operação");
                    alunos.Remove(nome);
                    notas1.Remove(nota1);
                    return;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!! Tente novamente");
                    alunos.Remove(nome);
                    notas1.Remove(nota1);
                    return;
                }
                notas2.Add(nota2);

                Write("\nDigite o código identificador da turma do aluno: ");
                string codTurma = ReadLine();
                if (codigoIdentificador.Contains(codTurma) == false)
                {
                    WriteLine("Código de turma inválido! Refaça a operação.");
                    alunos.Remove(nome);
                    notas1.Remove(nota1);
                    notas2.Add(nota2);
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
                WriteLine("Pressione qualquer tecla para voltar.");
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
                WriteLine("Pressione qualquer tecla para voltar.");
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
                    if (mediaCadaAluno[i] > 5 && mediaCadaAluno[i] < 7)
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
                WriteLine("Pressione qualquer tecla para voltar.");
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
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }

            Clear();
            WriteLine("TODOS ALUNOS:\n");
            for (var i = 0; i < mediaCadaAluno.Count; i++)
            {
                string cod = codigoAluno[i];
                int indexTurma = codigoIdentificador.IndexOf(cod);
                string nomeTurma;

                if (indexTurma >= 0)
                {
                    nomeTurma = turmas[indexTurma];
                }
                else
                {
                    nomeTurma = "[REMOVIDA]";
                }
                WriteLine($"Turma: {nomeTurma} || Código identificador da turma: {cod} || Nome: {alunos[i]} || 1° Nota: {notas1[i]} || 2° Nota: {notas2[i]} || Média: {Math.Round(mediaCadaAluno[i], 1)}");
            }
            WriteLine("Pressione qualquer tecla para voltar.");
            ReadKey();
            Clear();
        }


        public static void editarAluno()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
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
                        editarTurmaAluno();
                        break;
                    case "3":
                        editarNotaAluno();
                        break;
                    case "4":
                        editarTudo();
                        break;
                }
            }
        }
        private static void editarNomeAluno()
        {
            Clear();
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("Digite o nome do aluno que deseja editar: ");
                string nome = ReadLine();
                int index = alunos.IndexOf(nome);
                if (index >= 0)
                {
                    WriteLine("Deseja realmente editar o nome do aluno? (s) / (n)\n");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        WriteLine($"O aluno a ser editado é o {alunos[index]}.\n");
                        string nomeNovo = "";
                        do
                        {
                            Write("Redigite o nome do aluno: ");
                            nomeNovo = ReadLine();
                            if (string.IsNullOrWhiteSpace(nomeNovo))
                            {
                                WriteLine("O nome do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                ReadKey();
                                Clear();
                                return;
                            }
                        } while (string.IsNullOrWhiteSpace(nomeNovo));
                        var igual = alunos.Any(x => x == nomeNovo);
                        if (igual == true)
                        {
                            WriteLine("Este nome já está cadastrado. Tente novamente.");
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                            return;
                        }
                        else
                        {
                            alunos[index] = nomeNovo;
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("Nome alterado com sucesso!");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                    }
                    else if (opcao == "n")
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Operação cancelada! ");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida!");
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Este nome não consta em nossos registros!");
                    ResetColor();
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                    return;
                }
            }
        }
        private static void editarTurmaAluno()
        {
            Clear();
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("DIGITE O NOME DO ALUNO A SER EDITADO: ");
                string nome = ReadLine();
                int indexAluno = alunos.IndexOf(nome);
                if (indexAluno >= 0)
                {
                    string codigoTurmaAtual = codigoAluno[indexAluno];

                    if (string.IsNullOrEmpty(codigoTurmaAtual))
                    {
                        WriteLine($"O aluno {alunos[indexAluno]} não está associado a nenhuma turma.");
                        string novaTurma = "";
                        do
                        {
                            Write("Digite para qual turma o aluno será transferido: ");
                            novaTurma = ReadLine();
                            if (string.IsNullOrWhiteSpace(novaTurma))
                            {
                                WriteLine("A turma do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                ReadKey();
                                Clear();
                                return;
                            }
                        } while (string.IsNullOrWhiteSpace(novaTurma));
                        string novoCodigoTurma = "";
                        do
                        {
                            Write("\nDigite o novo código da turma do aluno: ");
                            novoCodigoTurma = ReadLine();
                            if (string.IsNullOrWhiteSpace(novoCodigoTurma))
                            {
                                WriteLine("O código da turma não pode ser vazio. Por favor, insira um valor válido.");
                                ReadKey();
                                Clear();
                                return;
                            }
                        } while (string.IsNullOrWhiteSpace(novoCodigoTurma));

                        int indexNovaTurma = turmas.IndexOf(novaTurma);
                        int indexNovoCodigo = codigoIdentificador.IndexOf(novoCodigoTurma);

                        if (indexNovaTurma != -1 && indexNovoCodigo != -1 && indexNovaTurma == indexNovoCodigo)
                        {
                            codigoAluno[indexAluno] = novoCodigoTurma;

                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("Turma do aluno editada com sucesso!");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Código de turma ou nome de turma não encontrado! Refaça a operação.");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                    }
                    else
                    {
                        int indexTurmaAtual = codigoIdentificador.IndexOf(codigoTurmaAtual);

                        if (indexTurmaAtual == -1)
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Erro: A turma atual do aluno não foi encontrada.");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                            return;
                        }
                        string turmaAtual = turmas[indexTurmaAtual];
                        WriteLine($"O aluno a ser editado é: {alunos[indexAluno]}");
                        WriteLine($"Turma atual: {turmaAtual}");
                        WriteLine($"Código identificador da turma: {codigoTurmaAtual}\n");
                        WriteLine("Deseja realmente editar a turma do aluno? (s) / (n)\n");
                        string opcao = ReadLine().ToLower();
                        if (opcao == "s")
                        {
                            string novaTurma = "";
                            do
                            {
                                Write("Digite para qual turma o aluno será transferido: ");
                                novaTurma = ReadLine();
                                if (string.IsNullOrWhiteSpace(novaTurma))
                                {
                                    WriteLine("A turma do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                    ReadKey();
                                    Clear();
                                    return;
                                }
                            } while (string.IsNullOrWhiteSpace(novaTurma));
                            string novoCodigoTurma = "";
                            do
                            {
                                Write("Digite o código da nova turma do aluno: ");
                                novoCodigoTurma = ReadLine();
                                if (string.IsNullOrWhiteSpace(novoCodigoTurma))
                                {
                                    WriteLine("O código da turma não pode ser vazio. Por favor, insira um valor válido.");
                                    ReadKey();
                                    Clear();
                                    return;
                                }
                            } while (string.IsNullOrWhiteSpace(novoCodigoTurma));

                            int indexNovaTurma = turmas.IndexOf(novaTurma);
                            int indexNovoCodigo = codigoIdentificador.IndexOf(novoCodigoTurma);

                            if (indexNovaTurma != -1 && indexNovoCodigo != -1 && indexNovaTurma == indexNovoCodigo)
                            {
                                codigoAluno[indexAluno] = novoCodigoTurma;

                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("Turma do aluno editada com sucesso!");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("Código de turma ou nome de turma não encontrado! Refaça a operação.");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                            }
                        }
                        else if (opcao == "n")
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Operação cancelada!");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            WriteLine("Digite uma entrada válida!");
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("O aluno digitado não consta em nossos registros!");
                    ResetColor();
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                    return;
                }
            }
        }
        private static void editarNotaAluno()
        {
            Clear();
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("DIGITE O NOME DO ALUNO A SER EDITADO: ");
                string nome = ReadLine();
                int indexAluno = alunos.IndexOf(nome);
                if (indexAluno >= 0)
                {
                    WriteLine("Deseja realmente editar as notas do aluno? (s) / (n)\n");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        double tent, tent1;
                        double novaNota1 = 0, novaNota2 = 0;
                        WriteLine($"O aluno a ser editado é o {alunos[indexAluno]}.\n");
                        Write("Digite a nova 1ª nota do aluno: ");
                        try
                        {
                            do
                            {
                                tent = Convert.ToDouble(ReadLine());
                                if (tent < 0 || tent > 10)
                                {
                                    WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                                    ReadKey();
                                }
                                novaNota1 = tent;
                                break;
                            } while (true);

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
                        notas1[indexAluno] = novaNota1;
                        WriteLine();
                        Write("\nDigite a nova 2ª nota do aluno: ");
                        try
                        {
                            do
                            {
                                tent1 = Convert.ToDouble(ReadLine());
                                if (tent1 < 0 || tent1 > 10)
                                {
                                    WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                                    ReadKey();
                                }
                                novaNota2 = tent1;
                                break;
                            } while (true);
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
                        notas2[indexAluno] = novaNota2;
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("\nNova nota cadastrada com sucesso!\n");
                        ResetColor();
                        double novaMedia = (notas1[indexAluno] + notas2[indexAluno]) / 2;
                        mediaCadaAluno[indexAluno] = novaMedia;
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                    else if (opcao == "n")
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Operação cancelada! ");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida!");
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Este nome não consta em nossos registros!");
                    ResetColor();
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                    return;
                }
            }
        }
        private static void editarTudo()
        {
            Clear();
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("DIGITE O NOME DO ALUNO A SER EDITADO: ");
                string nome = ReadLine();
                int indexAluno = alunos.IndexOf(nome);
                if (indexAluno >= 0)
                {
                    WriteLine($"O aluno a ser editado é o {alunos[indexAluno]}.\n");
                    WriteLine("Deseja realmente editar os dados do aluno? (s) / (n)\n");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        double tent, tent1;
                        double novaNota1 = 0, novaNota2 = 0;
                        string nomeNovo = "";
                        do
                        {
                            Write("Redigite o nome do aluno: ");
                            nomeNovo = ReadLine();
                            if (string.IsNullOrWhiteSpace(nomeNovo))
                            {
                                WriteLine("O nome do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                ReadKey();
                                Clear();
                                return;
                            }
                        } while (string.IsNullOrWhiteSpace(nomeNovo)); ;
                        var igual = alunos.Any(x => x == nomeNovo);
                        if (igual == true)
                        {
                            WriteLine("Este nome já está cadastrado. Tente novamente.");
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                            return;
                        }
                        else
                        {
                            alunos[indexAluno] = nomeNovo;
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("Nome alterado com sucesso!");
                            ResetColor();
                        }
                        string codigoTurmaAtual = codigoAluno[indexAluno];

                        if (string.IsNullOrEmpty(codigoTurmaAtual))
                        {
                            WriteLine($"O aluno {alunos[indexAluno]} não está associado a nenhuma turma.");
                            string novaTurma = "";
                            do
                            {
                                Write("Digite a nova turma do aluno: ");
                                novaTurma = ReadLine();
                                if (string.IsNullOrWhiteSpace(novaTurma))
                                {
                                    WriteLine("A turma do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                    ReadKey();
                                    Clear();
                                    return;
                                }
                            } while (string.IsNullOrWhiteSpace(novaTurma));
                            string novoCodigoTurma = "";
                            do
                            {
                                Write("Digite o novo código da turma do aluno: ");
                                nomeNovo = ReadLine();
                                if (string.IsNullOrWhiteSpace(novoCodigoTurma))
                                {
                                    WriteLine("O código da turma do aluno não pode ser vazio. Por favor, insira um valor válido.");
                                    ReadKey();
                                    Clear();
                                    return;
                                }
                            } while (string.IsNullOrWhiteSpace(novoCodigoTurma));

                            int indexNovaTurma = turmas.IndexOf(novaTurma);
                            int indexNovoCodigo = codigoIdentificador.IndexOf(novoCodigoTurma);

                            if (indexNovaTurma != -1 && indexNovoCodigo != -1 && indexNovaTurma == indexNovoCodigo)
                            {
                                codigoAluno[indexAluno] = novoCodigoTurma;

                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("Turma do aluno editada com sucesso!");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("Código de turma ou nome de turma não encontrado! Refaça a operação.");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                            }
                        }
                        else
                        {
                            int indexTurmaAtual = codigoIdentificador.IndexOf(codigoTurmaAtual);

                            if (indexTurmaAtual == -1)
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("Erro: A turma atual do aluno não foi encontrada.");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                                return;
                            }

                            string turmaAtual = turmas[indexTurmaAtual];
                            WriteLine($"Turma atual: {turmaAtual}");
                            WriteLine($"Código identificador da turma: {codigoTurmaAtual}\n");

                            Write("\nPara qual turma o aluno será transferido: ");
                            string novaTurma = ReadLine();
                            Write("\nDigite o código da turma que o aluno será transferido: ");
                            string novoCodigoTurma = ReadLine();

                            int indexNovaTurma = turmas.IndexOf(novaTurma);
                            int indexNovoCodigo = codigoIdentificador.IndexOf(novoCodigoTurma);

                            if (indexNovaTurma != -1 && indexNovoCodigo != -1 && indexNovaTurma == indexNovoCodigo)
                            {
                                codigoAluno[indexAluno] = novoCodigoTurma;

                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("Turma do aluno editada com sucesso!");
                                ResetColor();
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("Código de turma ou nome de turma não encontrado! Refaça a operação.");
                                ResetColor();
                                WriteLine("Pressione qualquer tecla para voltar.");
                                ReadKey();
                                Clear();
                                return;
                            }
                        }

                        WriteLine("EDITAR NOTAS\n");

                        try
                        {
                            do
                            {
                                Write("Digite a nova 1ª nota do aluno: ");
                                tent = Convert.ToDouble(ReadLine());
                                if (tent < 0 || tent > 10)
                                {
                                    WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                                    continue;
                                }
                                novaNota1 = tent;
                                break;
                            } while (true);
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
                        notas1[indexAluno] = novaNota1;
                        WriteLine();
                        Write("\nDigite a nova 2ª nota do aluno: ");
                        try
                        {
                            do
                            {
                                tent1 = Convert.ToDouble(ReadLine());
                                if (tent1 < 0 || tent1 > 10)
                                {
                                    WriteLine("Nota inválida! A nota deve ser entre 0 e 10. Tente novamente.");
                                    continue;
                                }
                                novaNota2 = tent1;
                                break;
                            } while (true);
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
                        notas2[indexAluno] = novaNota2;
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("\nNota alterada com sucesso!\n");
                        ResetColor();
                        double novaMedia = (notas1[indexAluno] + notas2[indexAluno]) / 2;
                        mediaCadaAluno[indexAluno] = novaMedia;
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Todos dados foram alterados com sucesso!");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                        return;
                    }
                    else if (opcao == "n")
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Operação cancelada! ");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida!");
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }

                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Este nome não consta em nossos registros!");
                    ResetColor();
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                    return;
                }
            }
        }


        private static void editarTurma()
        {
            Clear();
            if (turmas.Count == 0)
            {
                WriteLine("Nenhuma turma cadastrada.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }

            Write("DIGITE O NOME DA TURMA QUE VOCÊ DESEJA EDITAR: ");
            string nome = ReadLine();
            Write("\nDIGITE O CÓDIGO ATUAL DA TURMA: ");
            string idxCod = ReadLine();
            int index = turmas.IndexOf(nome);
            int indexCod = codigoIdentificador.IndexOf(idxCod);

            if (index < 0 || indexCod < 0 || index != indexCod)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("O nome da turma ou o código não coincidem. Tente novamente.");
                ResetColor();
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }

            WriteLine($"\nA turma a ser editada é o {turmas[index]} e seu código identificador é o {codigoIdentificador[indexCod]}.\n");
            string novoNome = "";
            do
            {
                Write("Redigite o nome da turma: ");
                novoNome = ReadLine();
                if (string.IsNullOrWhiteSpace(novoNome))
                {
                    WriteLine("O nome do aluno não pode ser vazio. Por favor, insira um valor válido.");
                    ReadKey();
                    Clear();
                    return;
                }
            } while (string.IsNullOrWhiteSpace(novoNome));
            var igual = turmas.Any(x => x == novoNome);
            if (igual == true || novoNome == turmas[index])
            {
                WriteLine("O nome digitado já está cadastrado ou é igual ao anterior. Tente novamente.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            string novoCod = "";
            do
            {
                Write("\nDigite o novo código da turma: ");
                novoCod = ReadLine();
                if (!string.IsNullOrWhiteSpace(novoCod))
                {
                    WriteLine("O código da turma não pode ser nulo ou vazio, insira um valor válido.");
                    ReadKey();
                    Clear();
                    return;
                }
            } while (string.IsNullOrWhiteSpace(novoCod));
            string codigoAntigo = codigoIdentificador[indexCod];
            codigoIdentificador[indexCod] = novoCod;
            turmas[index] = novoNome;

            for (int i = 0; i < codigoAluno.Count; i++)
            {
                if (codigoAluno[i] == codigoAntigo)
                {
                    codigoAluno[i] = novoCod;
                }
            }

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Turma editada com sucesso!");
            ResetColor();
            WriteLine("Pressione qualquer tecla para voltar.");
            ReadKey();
            Clear();
        }


        private static void excluirAluno()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum Aluno cadastrado.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("DIGITE O NOME DO ALUNO QUE DESEJA EXCLUIR: ");
                string nome = ReadLine();
                int idxAluno = alunos.IndexOf(nome);
                if (idxAluno >= 0)
                {
                    WriteLine($"\nO aluno a ser excluido é o {alunos[idxAluno]}.\n");
                    WriteLine("Excluir o aluno significa que irá excluir ele da turma e suas notas. Deseja realmente excluir? (s) / (n)");
                    string opcao = ReadLine().ToLower();
                    if (opcao == "s")
                    {
                        alunos.RemoveAt(idxAluno);
                        codigoAluno.RemoveAt(idxAluno);
                        notas1.RemoveAt(idxAluno);
                        notas2.RemoveAt(idxAluno);
                        mediaCadaAluno.RemoveAt(idxAluno);
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Aluno excluído com sucesso! ");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                        return;
                    }
                    else if (opcao == "n")
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Operação cancelada! ");
                        ResetColor();
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                        return;
                    }
                    else
                    {
                        WriteLine("Digite uma entrada válida! ");
                        WriteLine("Pressione qualquer tecla para voltar.");
                        ReadKey();
                        Clear();
                    }

                }
                else
                {
                    WriteLine("Este nome não existe nos registros.");
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                }
            }

        }

        private static void excluirTurma()
        {
            if (turmas.Count == 0)
            {
                WriteLine("Nenhuma turma cadastrada.");
                WriteLine("Pressione qualquer tecla para voltar.");
                ReadKey();
                Clear();
                return;
            }
            else
            {
                Write("DIGITE O NOME DA TURMA QUE VOCÊ DESEJA EXCLUIR: ");
                string turmaASerDel = ReadLine();
                int indexTurma = turmas.IndexOf(turmaASerDel);
                if (indexTurma >= 0)
                {
                    int quantidadeAlunosNaTurma = 0;
                    for (int i = 0; i < codigoAluno.Count; i++)
                    {
                        if (codigoAluno[i] == codigoIdentificador[indexTurma])
                        {
                            quantidadeAlunosNaTurma++;
                        }
                    }
                    if (quantidadeAlunosNaTurma == 0)
                    {
                        WriteLine("Esta turma não possui nenhum aluno, deseja exclui-la? (s) / (n)\n");
                        string resposta1 = ReadLine();
                        if (resposta1 == "s")
                        {
                            turmas.RemoveAt(indexTurma);
                            codigoIdentificador.RemoveAt(indexTurma);
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("Turma excluída com sucesso! ");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else if (resposta1 == "n")
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Operação cancelada! ");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            WriteLine("Digite uma entrada válida.");
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                    }
                    else
                    {
                        string codTurma = codigoIdentificador[indexTurma];
                        WriteLine("A turma possui alunos associados. Deseja desvincular os alunos e excluir a turma? (s) / (n)\n");
                        string resposta = ReadLine();
                        if (resposta == "s")
                        {
                            for (int i = 0; i < codigoAluno.Count; i++)
                            {
                                if (codigoAluno[i] == codTurma)
                                {
                                    codigoAluno[i] = "";
                                }
                            }

                            turmas.RemoveAt(indexTurma);
                            codigoIdentificador.RemoveAt(indexTurma);

                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("Turma excluída com sucesso e alunos desvinculados!");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else if (resposta == "n")
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Operação cancelada! ");
                            ResetColor();
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            WriteLine("Digite uma entrada válida.");
                            WriteLine("Pressione qualquer tecla para voltar.");
                            ReadKey();
                            Clear();
                        }
                    }
                }
                else
                {
                    WriteLine("A turma não existe em nossos registros");
                    WriteLine("Pressione qualquer tecla para voltar.");
                    ReadKey();
                    Clear();
                }
            }
        }
        private static void gravarArquivo()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            string caminhoArquivo = "TrabalhoEmerson.csv";
            using (var writer = new StreamWriter(caminhoArquivo, false))
            {
                writer.WriteLine("Nome,Turma,CodigoIdentificador,CodigoAluno,Nota1,Nota2,Media");
                for (int i = 0; i < alunos.Count; i++)
                {
                    int idxTurma = codigoIdentificador.IndexOf(codigoAluno[i]);
                    string nomeTurma;

                    if (idxTurma >= 0)
                    {
                        nomeTurma = turmas[idxTurma];
                    }
                    else
                    {
                        nomeTurma = "[REMOVIDA]";
                    }
                    writer.WriteLine($"{alunos[i]},{nomeTurma},{codigoIdentificador[idxTurma]},{codigoAluno[i]},{notas1[i]},{notas2[i]},{mediaCadaAluno[i]}");
                }
            }
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Arquivo gravado com sucesso em: " + Path.GetFullPath(caminhoArquivo));
            ResetColor();
        }

        private static void lerArquivo()
        {
            if (alunos.Count == 0)
            {
                WriteLine("Nenhum aluno cadastrado.");
                return;
            }
            string caminhoArquivo = "TrabalhoEmerson.csv";
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            alunos.Clear();
            turmas.Clear();
            codigoIdentificador.Clear();
            codigoAluno.Clear();
            notas1.Clear();
            notas2.Clear();
            mediaCadaAluno.Clear();

            var linhas = File.ReadAllLines(caminhoArquivo);
            for (int i = 1; i < linhas.Length; i++)
            {
                var col = linhas[i].Split(',');
                if (col.Length != 7) continue;

                alunos.Add(col[0]);

                string turmaNome = col[1];
                string codId = col[2];
                if (!codigoIdentificador.Contains(codId))
                {
                    turmas.Add(turmaNome);
                    codigoIdentificador.Add(codId);
                }
                codigoAluno.Add(codId);
                notas1.Add(Convert.ToDouble(col[4]));
                notas2.Add(Convert.ToDouble(col[5]));
                mediaCadaAluno.Add(Convert.ToDouble(col[6]));
            }
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Leitura concluída com sucesso. Total de alunos: " + alunos.Count);
            ResetColor();
        }
    }
}
