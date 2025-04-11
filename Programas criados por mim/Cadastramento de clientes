using static System.Console;

List<string> clientes = new List<string>();
while (true)
{
    WriteLine("Selecione uma opção:");
    WriteLine("1 - Adicionar cliente");
    WriteLine("2 - Visualizar clientes");
    WriteLine("3 - Editar cliente");
    WriteLine("4 - Excluir cliente");
    WriteLine("5 - Sair");

    int opcao = Convert.ToInt32(ReadLine());
    switch (opcao)
    {
        case 1:
            adicionarCliente();
            WriteLine("\n");
            break;
        case 2:
            visualizarClientes();
            WriteLine("\n");
            break;
        case 3:
            editarCliente();
            WriteLine("\n");
            break;
        case 4:
            excluirCliente();
            WriteLine("\n");
            break;
        case 5:
            WriteLine("Saindo...");
            WriteLine("\n");
            return;
        default:
            WriteLine("Opção inválida.");
            WriteLine("\n");
            break;
    }
}

string FormatarNome(string nome)
{
    return string.Join(" ", nome.Split(' ')
                                .Select(palavra => char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower()));
}

string adicionarCliente()
{
    WriteLine("Digite o nome do cliente:");
    string nome = ReadLine().ToLower();
    WriteLine("Digite o E-mail do cliente:");
    string email = ReadLine().ToLower();
    clientes.Add($"{nome}|{email}");
    WriteLine($"Cliente {FormatarNome(nome)} adicionado com sucesso!");
    return "";
}

void visualizarClientes()
{
    if (clientes.Count == 0)
    {
        WriteLine("Nenhum cliente cadastrado.");
    }
    else
    {
        WriteLine("Clientes cadastrados:");
        for (int i = 0; i < clientes.Count; i++)
        {
            string[] cliente = clientes[i].Split('|');
            WriteLine($"Cliente {i + 1}: Nome: {FormatarNome(cliente[0])} | E-mail: {cliente[1]}");
        }
    }
}



string editarCliente()
{
    WriteLine("Digite o nome do cliente que deseja editar:");
    string nome = ReadLine().ToLower();
    string clienteEncontrado = clientes.FirstOrDefault(c => c.StartsWith($"{nome}|"));

    if (clienteEncontrado != null)
    {
        string[] dados = clienteEncontrado.Split('|');
        string nomeAtual = dados[0];
        string emailAtual = dados[1];

        WriteLine($"Cliente encontrado: nome: {FormatarNome(nomeAtual)} | email: {emailAtual}");
        WriteLine("O que você deseja editar?");
        WriteLine("1 - Somente o nome");
        WriteLine("2 - Somente o e-mail");
        WriteLine("3 - Ambos");

        int escolha = Convert.ToInt32(ReadLine());
        switch (escolha)
        {
            case 1:
                WriteLine("Digite o novo nome do cliente:");
                string novoNome = ReadLine().ToLower();

                if (clientes.Any(c => c.StartsWith($"{novoNome}|")))
                {
                    WriteLine("Entrada inválida: o nome já está cadastrado.");
                }
                else
                {
                    clientes[clientes.IndexOf(clienteEncontrado)] = $"{novoNome}|{emailAtual}";
                    WriteLine($"Nome atualizado com sucesso! Novo registro: nome: {FormatarNome(novoNome)} | email: {emailAtual}");
                }
                break;

            case 2: 
                WriteLine("Digite o novo e-mail do cliente:");
                string novoEmail = ReadLine().ToLower();

                if (clientes.Any(c => c.EndsWith($"|{novoEmail}")))
                {
                    WriteLine("Entrada inválida: o e-mail já está cadastrado.");
                }
                else
                {
                    clientes[clientes.IndexOf(clienteEncontrado)] = $"{nomeAtual}|{novoEmail}";
                    WriteLine($"E-mail atualizado com sucesso! Novo registro: nome: {FormatarNome(nomeAtual)} | email: {novoEmail}");
                }
                break;

            case 3: 
                WriteLine("Digite o novo nome do cliente:");
                novoNome = ReadLine().ToLower();
                WriteLine("Digite o novo e-mail do cliente:");
                novoEmail = ReadLine().ToLower();

                if (clientes.Any(c => c.StartsWith($"{novoNome}|")))
                {
                    WriteLine("Entrada inválida: o nome já está cadastrado.");
                }
                else if (clientes.Any(c => c.EndsWith($"|{novoEmail}")))
                {
                    WriteLine("Entrada inválida: o e-mail já está cadastrado.");
                }
                else
                {
                    clientes[clientes.IndexOf(clienteEncontrado)] = $"{novoNome}|{novoEmail}";
                    WriteLine($"Nome e e-mail atualizados com sucesso! Novo registro: nome: {FormatarNome(novoNome)} | email: {novoEmail}");
                }
                break;

            default:
                WriteLine("Opção inválida.");
                break;
        }
    }
    else
    {
        WriteLine($"Cliente {nome} não encontrado.");
    }

    return "";
}



string excluirCliente()
{
    WriteLine("Digite o nome do cliente que deseja excluir:");
    string nome = ReadLine().ToLower();
    string clienteEncontrado = clientes.FirstOrDefault(c => c.StartsWith($"{nome}|"));

    if (clienteEncontrado != null)
    {
        clientes.Remove(clienteEncontrado);
        WriteLine($"Cliente {nome} excluído com sucesso!");
    }
    else
    {
        WriteLine($"Cliente {nome} não encontrado.");
    }

    return "";
}
