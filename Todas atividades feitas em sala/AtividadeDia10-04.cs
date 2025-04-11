using static System.Console;

WriteLine("1°Exercício de lista.");
string novoNome; // Crio uma variavel para ser adicionado depois na array
WriteLine("Digite seu nome para ser adicionado a lista.");
novoNome = ReadLine();
string[] nomes = { "Djeffer", "Gabriel", "Luiz", "Daniel", "Erinaldo" }; // Criando uma array
List<string> listaNome = new List<string>(nomes.ToList()); // Transformo o array em uma lista
listaNome.Add(novoNome); // Adiciono a variavel dentro da lista
nomes = listaNome.ToArray(); // Pego a lista e converto de volta para array
Array.Sort(nomes);// Organizo por ordem alfabética
WriteLine($"Tamanho do array: {nomes.Length}");// Mostro a quantidade de itens no array
foreach (var item in nomes)
{
    Write(item + ", ");
}

WriteLine("\n");
WriteLine("2° Exercício"); // Crio uma variavel, uso o for para repetir 5 vezes o mesmo código, depois adiciono o número digitado na lista.
int num;
int[] arrayNum = { };
for (int i = 0; i < 5; i++)
{
    WriteLine($"Digite o {i + 1}° número:");
    num = Convert.ToInt32(ReadLine());
    List<int> listaNum = new List<int>(arrayNum.ToList());
    listaNum.Add(num);
    arrayNum = listaNum.ToArray();
    Array.Sort(arrayNum);
}
WriteLine("\nOs números digitados foram:");
for (int i = 0; i < arrayNum.Length; i++)
{
    if (i == arrayNum.Length - 1)
    {
        Write(arrayNum[i] + ".");
    }
    else if (i == arrayNum.Length - 2)
    {
        Write(arrayNum[i] + " e ");
    }
    else
    {
        Write(arrayNum[i] + ", ");
    }
}

WriteLine("\n");
WriteLine("3° Exercício:");
// Crio uma variavel, uso o for para repetir 10 vezes o mesmo código, depois adiciono o número digitado na lista. Faço uma verificação se o número é par ou ímpar, e adiciono na lista correspondente.
int numero;
int[] arrayNumeros = { };
int[] arrayPar = { };
int[] arrayImpar = { };
for (int i = 0; i < 5; i++)
{
    WriteLine("Digite um número:");
    numero = Convert.ToInt32(ReadLine());
    if (numero % 2 == 0)
    {
        // Se o número for par, adiciona na lista de números pares
        List<int> listaPar = new List<int>(arrayPar.ToList());
        listaPar.Add(numero);
        arrayPar = listaPar.ToArray();
        Array.Sort(arrayPar);// Organizo por ordem crescente
    }
    else
    {
        // Se o número for ímpar, adiciona na lista de números ímpares
        List<int> listaImpar = new List<int>(arrayImpar.ToList());
        listaImpar.Add(numero);
        arrayImpar = listaImpar.ToArray();
        Array.Sort(arrayImpar);// Organizo por ordem crescente
    }
    // Adiciona o número à lista de números
    List<int> listaNumeros = new List<int>(arrayNumeros.ToList());
    listaNumeros.Add(numero);
    arrayNumeros = listaNumeros.ToArray();
    Array.Sort(arrayNumeros);// Organizo por ordem crescente
}
WriteLine("Os números digitados foram:");
for (int i = 0; i < arrayNumeros.Length; i++)
{
    if (i == arrayNumeros.Length - 1)
    {
        Write(arrayNumeros[i] + ".");
    }
    else if (i == arrayNumeros.Length - 2)
    {
        Write(arrayNumeros[i] + " e ");
    }
    else
    {
        Write(arrayNumeros[i] + ", ");
    }
}
WriteLine("\n");
WriteLine("Os números pares digitados foram:");
for (int i = 0; i < arrayPar.Length; i++)
{
    if (i == arrayPar.Length - 1)
    {
        Write(arrayPar[i] + ".");
    }
    else if (i == arrayPar.Length - 2)
    {
        Write(arrayPar[i] + " e ");
    }
    else
    {
        Write(arrayPar[i] + ", ");
    }
}
WriteLine("\n");
WriteLine("Os números ímpares digitados foram:");
for (int i = 0; i < arrayImpar.Length; i++)
{
    if (i == arrayImpar.Length - 1)
    {
        Write(arrayImpar[i] + ".");
    }
    else if (i == arrayImpar.Length - 2)
    {
        Write(arrayImpar[i] + " e ");
    }
    else
    {
        Write(arrayImpar[i] + ", ");
    }
}
ReadLine();
