EXERCÍCIOS DA AULA 14/04 FEITOS EM SALA E DURANTE TODO O RESTO DO PERÍODO. CONTEÚDO: LISTAS
ALUNO: DJEFFER BERVIAN PRANGE

1- Escreva uma aplicação que leia em duas listas, o nome de 10 estudantes e
sua respectiva idade. Ordene os vetores e informe qual é o estudante mais
velho e o mais novo.

using static System.Console;
List<string> nomes = new List<string>();
List<int> idade = new List<int>();

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite o nome do {i}º estudante:");
    nomes.Add(ReadLine());
}

WriteLine("\n");

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite a idade do {i}º estudante:");
    idade.Add(Convert.ToInt32(ReadLine()));
}

int maisNovo = idade[0], maisVelho = idade[0];

for (int i = 1; i < idade.Count; i++)
{
    if (idade[i] < maisNovo)
    {
        maisNovo = idade[i];
    }
    if (idade[i] > maisVelho)
    {
        maisVelho = idade[i];
    }
}


int idxMenor = idade.IndexOf(maisNovo);
int idxMaior = idade.IndexOf(maisVelho);


WriteLine($"\nO estudante com maior idade é {nomes[idxMenor]} , com  {maisNovo} anos.\n");
WriteLine($"O estudante com menor idade é {nomes[idxMenor]}, com {maisNovo} anos.");


2- Faça um programa que crie uma lista, e peça ao usuário digitar 10 nomes e
10 notas, de uma turma TDS, exiba ao final a média das notas da turma, e
imprima o nome do aluno e sua nota.

using static System.Console;

List<string> nomes = new List<string>();
List<double> notas = new List<double>();

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite o nome do {i}º estudante:");
    nomes.Add(ReadLine());
}

WriteLine("\n");

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite a nota do {i}º estudante:");
    notas.Add(Convert.ToInt32(ReadLine()));
}

WriteLine("Nomes e notas dos estudantes:");
for (int i = 0; i < 10; i++)
{
    WriteLine($"{i + 1}º estudante: {nomes[i]} - Nota: {notas[i]}");
}
double media = notas.Sum() / notas.Count;
WriteLine($"A média das notas é: {media}");

3- Uma agência de publicidade pediu à agência de modelos Luz & Beleza para
encontrar uma modelo que tenha idade entre 18 e 20 anos para participar
de uma campanha publicitária milionária de produtos de beleza. Foram
inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais
informações foram armazenadas em 2 listas. Faça um programa para
imprimir uma lista que contém os nomes das candidatas aptas a concorrer
a uma vaga para a campanha milionária.
using static System.Console;

List<string> nomes = new List<string>();
List<int> idades = new List<int>();
for (int i = 0; i < 20; i++)
{
    WriteLine($"Digite o nome da candidata {i + 1}:");
    string nome = ReadLine();
    nomes.Add(nome);
    WriteLine($"Digite a idade da candidata {i + 1}:");
    int idade = int.Parse(ReadLine());
    idades.Add(idade);
}
List<string> candidatasAptas = new List<string>();
for (int i = 0; i < 20; i++)
{   
    if (idades[i] >= 18 && idades[i] <= 20)
    {
        candidatasAptas.Add(nomes[i]);
    }
    else
    {
        WriteLine($"A candidata {nomes[i]} não está apta para a campanha.");
        nomes.RemoveAt(i);
    }
}

4- Leia 2 listas de inteiros V1 e V2 de 20 componentes cada. Determine e
imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas
posições.
// Pesquisei como usa o random no c# para fazer este exercício :)
using static System.Console;


List<int> v1 = new List<int>();
List<int> v2 = new List<int>();
Random random = new Random();
for (int i = 0; i < 20; i++)
{
    v1.Add(random.Next(1, 100));
    v2.Add(random.Next(1, 100));
}
WriteLine("V1:");
for (int i = 0; i < v1.Count; i++)
{
    if (i == v1.Count - 1)
    {
        Write(v1[i] + ".");
    }
    else if (i == v1.Count - 2)
    {
        Write(v1[i] + " e ");
    }
    else
    {
        Write(v1[i] + ", ");
    }
}
WriteLine("V2:");
for (int i = 0; i < v2.Count; i++)
{
    if (i == v2.Count - 1)
    {
        Write(v2[i] + ".");
    }
    else if (i == v2.Count - 2)
    {
        Write(v2[i] + " e ");
    }
    else
    {
        Write(v2[i] + ", ");
    }
}
int iguais = 0;
for (int i = 0; i < 20; i++)
{
    if (v1[i] == v2[i])
    {
        iguais++;
    }
}
WriteLine($"V1 e V2 possuem {iguais} valores idênticos nas mesmas posições.");

5- Fazer um programa para ler uma quantidade 15 de alunos. Ler a nota de
cada um dos 15 alunos e calcular a média aritmética das notas. Contar
quantos alunos estão com a nota acima de 7.0.
Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não
há nenhum aluno com nota acima de 5.
using static System.Console;

List<string> nomes = new List<string>
{
    "Ana", "Bruno", "Carlos", "Daniela", "Eduardo",
    "Fernanda", "Gabriel", "Helena", "Igor", "Juliana",
    "Kleber", "Larissa", "Marcos", "Natália", "Otávio"
};

List<double> notas = new List<double>
{
    8.5, 6.0, 7.2, 9.0, 5.5,
    4.0, 7.8, 6.5, 8.0, 5.0,
    3.5, 9.5, 6.8, 7.0, 4.5
};

double media = notas.Sum() / notas.Count;
WriteLine($"A média das notas é: {Math.Round(media, 2)}");

int alunosAcimaDeSete = 0;
for (int i = 0; i < notas.Count; i++)
{
    if (notas[i] > 7)
    {
        alunosAcimaDeSete++;
        WriteLine($"Aluno: {nomes[i]}, Nota: {notas[i]}");
    }
}

if (alunosAcimaDeSete > 0)
{
    WriteLine($"A quantidade de alunos com nota acima de 7.0 é: {alunosAcimaDeSete}");
}
else
{
    WriteLine("Não há nenhum aluno com nota acima de 7.0.");
}

if (notas.All(nota => nota <= 5))
{
    WriteLine("Não há nenhum aluno com nota acima de 5.");
}

6- Durante uma corrida de automóveis com 12 voltas de duração foram
anotados para um piloto, na ordem, os tempos registrados em cada volta.
Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
✓ melhor tempo;
✓ a volta em que o melhor tempo ocorreu;
✓ tempo médio das 12 voltas.
using static System.Console;

List<double> tempos = new List<double>
{
    134.5, 120.3, 145.8, 110.2, 98.7, 87.6, 140.4, 75.3, 130.1, 90.5, 65.2, 150.0
};

double melhorTempo, tempoMedio;
melhorTempo = tempos[0];
for (int i = 1; i < tempos.Count; i++)
{
    if (tempos[i] < melhorTempo)
    {
        melhorTempo = tempos[i];
    }
}
WriteLine($"Melhor tempo: {melhorTempo}");
int voltaMelhorTempo = 0;
for (int i = 0; i < tempos.Count; i++)
{
    if (tempos[i] == melhorTempo)
    {
        voltaMelhorTempo = i + 1; 
        break;
    }
}
WriteLine($"Volta em que o melhor tempo ocorreu: {voltaMelhorTempo}");
tempoMedio = tempos.Sum() / tempos.Count;
WriteLine($"Tempo médio das 12 voltas: {tempoMedio}");

7- Fazer um programa para armazenar em uma lista, vários números inteiros
e positivos e calcular a média. Imprimir também o maior. A quantidade de
números lidos será definida pelo usuário.
using static System.Console;
List<int> numeros = new List<int>();
int quantidade, media, maior;
WriteLine("Quantos números você deseja inserir?");
quantidade = Convert.ToInt32(ReadLine());
for (int i = 0; i < quantidade; i++)
{
    WriteLine($"Digite o {i + 1}º número:");
    numeros.Add(Convert.ToInt32(ReadLine()));
}
maior = numeros[0];
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
}
media = numeros.Sum() / numeros.Count;
WriteLine($"A média é: {media}");
WriteLine($"O maior número é: {maior}");

8- Faça um programa que pergunte ao usuário o número de alunos a ser lido.
O tamanho das listas será o número informado pelo usuário. Armazene
numa lista G1 as notas destes alunos; numa outra lista, armazene as notas
G2 destes alunos. Ambas as notas, G1 e G2, são informadas pelo usuário.
Calcule a média aritmética destes alunos e armazene num terceiro vetor.
Ao final, mostre as 3 notas dos alunos.

using static System.Console;
WriteLine("Informe o número de alunos:");
int n = Convert.ToInt32(ReadLine());
List<double> g1 = new List<double>(n);
List<double> g2 = new List<double>(n);
List<double> media = new List<double>();
for (int i = 0; i < n; i++)
{
    WriteLine($"Informe a nota do aluno {i + 1} da G1:");
    g1.Add(Convert.ToDouble(ReadLine()));
    WriteLine($"Informe a nota do aluno {i + 1} da G2:");
    g2.Add(Convert.ToDouble(ReadLine()));
    media.Add((g1[i] + g2[i]) / 2);
}
WriteLine("Notas dos alunos:");
for (int i = 0; i < n; i++)
{
    WriteLine($"Aluno {i + 1}: G1: {g1[i]}, G2: {g2[i]}, Média: {media[i]}");
}

9- Escreva uma aplicação no qual o usuário deverá informar 10 números
inteiro e maiores que Zero em uma lista. Em uma segunda lista, armazene
apenas os números pares e em um terceiro apenas os ímpares. Exiba as 3
listas, todos em ordem crescente.
using static System.Console;
int num;
List<int> lista = new List<int>();
List<int> listaPar = new List<int>();
List<int> listaImpar = new List<int>();
WriteLine("Informe 10 números inteiros e maiores que zero:");
for (int i = 0; i < 10; i++)
{
    num = Convert.ToInt32(ReadLine());
    if (num > 0)
    {
        lista.Add(num);
        if (num % 2 == 0)
        {
            listaPar.Add(num);
        }
        else
        {
            listaImpar.Add(num);
        }
    }
    else
    {
        WriteLine("Número inválido. Informe um número maior que zero.");
        i--; // Descobri que fazer isso volta o índice do loop uma unidade, ou seja, se o usuário informar um número inválido, o loop não avança e pede novamente o número. Dai não acontece de o programa pedir 11 números, por exemplo.
    }
}
lista.Sort();
listaPar.Sort();
listaImpar.Sort();
WriteLine("\nOs números digitados foram:");
for (int i = 0; i < lista.Count; i++)
{
    if (i == lista.Count - 1)
    {
        Write(lista[i] + ".");
    }
    else if (i == lista.Count - 2)
    {
        Write(lista[i] + " e ");
    }
    else
    {
        Write(lista[i] + ", ");
    }
}
WriteLine("\n\nOs números pares digitados foram:");
for (int i = 0; i < listaPar.Count; i++)
{
    if (i == listaPar.Count - 1)
    {
        Write(listaPar[i] + ".");
    }
    else if (i == listaPar.Count - 2)
    {
        Write(listaPar[i] + " e ");
    }
    else
    {
        Write(listaPar[i] + ", ");
    }
}
WriteLine("\n\nOs números ímpares digitados foram:");
for (int i = 0; i < listaImpar.Count; i++)
{
    if (i == listaImpar.Count - 1)
    {
        Write(listaImpar[i] + ".");
    }
    else if (i == listaImpar.Count - 2)
    {
        Write(listaImpar[i] + " e ");
    }
    else
    {
        Write(listaImpar[i] + ", ");
    }
}


Escreva um algoritmo que leia uma lista de 13 elementos inteiros, que é o Gabarito de um teste da loteria esportiva, contendo os valores 1(coluna 1), 2 (coluna 2) e 3 (coluna do meio). Leia, a seguir, para cada apostador, o número do seu cartão e uma lista de Respostas de 13 posições. Verifique para cada apostador os números de acertos, comparando a lista do Gabarito com a lista de Respostas. Escreva o nome do apostador e o número de acertos. Se o apostador tiver 13 acertos, mostrar a mensagem
"Ganhador".
using static System.Console;

List<int> gabarito = new List<int>
{
    13, 27, 5, 19, 22, 8, 30, 14, 3, 25, 7, 18, 11
};

WriteLine("Quantos apostadores?");
int quantidadeApostadores = Convert.ToInt32(ReadLine());

List<string> nomesJogadores = new List<string>();
List<int> numerosCartao = new List<int>();
List<List<int>> respostasApostadores = new List<List<int>>();
List<int> acertosApostadores = new List<int>();

for (int i = 0; i < quantidadeApostadores; i++)
{
    WriteLine($"\nApostador {i + 1}:");

    Write("Nome: ");
    string nome = ReadLine();
    nomesJogadores.Add(nome);

    Write("Número do cartão: ");
    int numeroCartao = Convert.ToInt32(ReadLine());
    numerosCartao.Add(numeroCartao);

    List<int> respostas = new List<int>();
    for (int j = 0; j < 13; j++)
    {
        Write($"Resposta {j + 1}: ");
        respostas.Add(Convert.ToInt32(ReadLine()));
    }
    respostasApostadores.Add(respostas);

    int acertos = 0;
    for (int j = 0; j < 13; j++)
    {
        if (respostas[j] == gabarito[j])
        {
            acertos++;
        }
    }
    acertosApostadores.Add(acertos);
}

WriteLine("\nResultados:");
int maiorAcertos = 0;
string ganhador = "";

for (int i = 0; i < quantidadeApostadores; i++)
{
    WriteLine($"\nApostador: {nomesJogadores[i]}");
    WriteLine($"Número do cartão: {numerosCartao[i]}");
    WriteLine($"Números escolhidos: ");
    WriteLine($"Números escolhidos: ");
    for (int k = 0; k < respostasApostadores[i].Count; k++)
    {
        if (k == respostasApostadores[i].Count - 1)
        {
            Write(respostasApostadores[i][k] + "."); 
        }
        else if (k == respostasApostadores[i].Count - 2)
        {
            Write(respostasApostadores[i][k] + " e "); 
        }
        else
        {
            Write(respostasApostadores[i][k] + ", "); 
        }
    }


    WriteLine($"\nAcertos: {acertosApostadores[i]}/{gabarito.Count}");

    if (acertosApostadores[i] > maiorAcertos)
    {
        maiorAcertos = acertosApostadores[i];
        ganhador = nomesJogadores[i];
    }
}

if (maiorAcertos == 13)
{
    WriteLine($"\nO Ganhador é {ganhador} com {maiorAcertos} acertos!");
}
else
{
    WriteLine("\nNenhum apostador acertou todos os números.");
}
