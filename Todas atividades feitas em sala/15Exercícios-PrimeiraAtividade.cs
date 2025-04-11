using static System.Console;

//1 - Verificação de Paridade:
int ePar(int a)
{
    if (a % 2 == 0)
    {
        WriteLine($"O número {a} é Par.");
    }
    else
    {
        WriteLine($"O número {a} é Ímpar.");
    }
    return a;
}
int numPar;
WriteLine("Digite um número para descobrir se ele é par ou ímpar.");
numPar = Convert.ToInt32(ReadLine());
ePar(numPar);

// 2 - Classificação por Idade:

int filtrarPorIdade(int a)
{
    if(a >= 0 & a <= 12)
    {
        WriteLine($"Você é uma criança porque tem {a} anos.");
    }
    else if(a >= 13 && a <= 17)
    {
        WriteLine($"Você é um adolescente porque tem {a} anos.");
    }
    else if (a >= 18 && a <= 59)
    {
        WriteLine($"Você é um adulto porque tem {a} anos.");
    }
    else if (a >= 60)
    {
        WriteLine($"Você é um idoso porque tem {a} anos.");
    }
    else
    {
        WriteLine("Você digitou uma entrada inválida, tente novamente.");
    }
    return a;
}

int idade;
WriteLine("Digite sua idade para saber sua classificação");
idade = Convert.ToInt32(ReadLine());
filtrarPorIdade(idade);

// 3 - Calculadora Simples

double calculadoraSimples(string c, double a, double b)
{
    string adicao = "+", subtracao = "-", multiplicacao = "*", multiplicacao1 = "x", multiplicacao2 = "X", divisao = "/";
    if (c == adicao)
    {
        WriteLine($"O resultado de {a} {c} {b} é {a + b}.");
    }
    else if (c == subtracao) {
        WriteLine($"O resultado de {a} {c} {b} é {a - b}.");
    }
    else if (c == multiplicacao || c == multiplicacao1 || c == multiplicacao2)
    {
        WriteLine($"O resultado de {a} {c} {b} é {a * b}.");
    }
    else if (c == divisao)
    {           
        if (b != 0)
        {
            WriteLine($"O resultado de {a} {c} {b} é {a / b}.");

        }
        else
        {
            WriteLine("Não existe divisão por 0.");
        }
    }
    return a;

}


double num1, num2;
string operador;
WriteLine("Digite um número para efetuar uma operação");
num1 = Convert.ToDouble(ReadLine());
WriteLine("Digite outro número para efetuar uma operação");
num2 = Convert.ToDouble(ReadLine());
WriteLine("Digite uma operação entre (+) (-) (*) (/) para efetutar operações.");
operador = ReadLine();
calculadoraSimples(operador, num1, num2);

// 4 - Dia da Semana:

int diaSemana;
WriteLine("Insira um número entre 1 a 7 para exibir o dia da semana correspondente ao número fornecido.");
diaSemana = Convert.ToInt32(ReadLine());

switch (diaSemana)
{
    case 1:
        WriteLine("Domingo");
        break;
    case 2:
        WriteLine("Segunda-Feira");
        break;
    case 3:
        WriteLine("Terça-Feira");
        break;
    case 4:
        WriteLine("Quarta-Feira");
        break;
    case 5:
        WriteLine("Quinta-Feira");
        break;
    case 6:
        WriteLine("Sexa-Feira");
        break;
    case 7:
        WriteLine("Sábado");
        break;
    default:
        WriteLine("Não possui dia da semana correspondente a sua entrada.");
        break;
}

// 5.Verificação de Vogal/Consoante:
string vogalOuNao;
WriteLine("Digite uma letra do alfabeto e descubra se é vogal ou consoante!");
vogalOuNao = ReadLine().ToLower();
switch (vogalOuNao)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        WriteLine($"{vogalOuNao} é uma vogal.");
        break;
    case "b":
    case "c":
    case "d":
    case "f":
    case "g":
    case "h":
    case "j":
    case "k":
    case "l":
    case "m":
    case "n":
    case "p":
    case "q":
    case "r":
    case "s":
    case "t":
    case "v":
    case "w":
    case "x":
    case "y":
    case "z":
        WriteLine($"{vogalOuNao} é uma consoante.");
        break;
    default:
        WriteLine("A entrada fornecida não está no alfabeto.");
        break;
}

// 6 - Média Aritmética e Aprovação:

double mediaAluno(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if (media < 6.9)
    {
        WriteLine($"Você está reprovado pois sua média é {media} e a média necessária é 7.0");
    }
    else
    {
        WriteLine($"Você está aprovado pois sua média é {media}.");
    }
    return media;
}

double nota, nota1, nota2;
WriteLine("Digite sua nota:");
nota = Convert.ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota1 = Convert.ToDouble(ReadLine());
WriteLine("Digite sua nota:");
nota2 = Convert.ToDouble(ReadLine());
mediaAluno(nota, nota1, nota2);

//7 - Desconto por Faixa de Valor:
double descontoParavalor(double a)
{
    double desconto;
    if (a < 50)
    {
        WriteLine($"Sem desconto, preço original de R${a} porque seu produto custa menos de R$50,00.");
    }
    else if (a > 51 && a < 100)
    {
        desconto = a * 0.05;
        WriteLine($"Seu produto custa {a}, e você ganhou um desconto de 5%(R${Math.Round(desconto, 2)}) pois seu produto custa entre 51 e 100 reais.");
    }
    else if (a > 101)
    {
        desconto = a * 0.1;
        double valorFinal = a - desconto;
        WriteLine($"Seu produto custa {a}, e você ganhou um desconto de 10%(R${Math.Round(desconto, 2)}) pois seu produto custa mais que R$100. O valor final do produto é {Math.Round(valorFinal, 2)}.");
    }
    return a;
}
double produto;
WriteLine("Digite o valor do produto que você vai comprar: ");
produto = Convert.ToDouble(ReadLine());
descontoParavalor(produto);

// 8 - Ano Bissexto:

int descobrirAnoBissexto(int a)
{
    if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0)){
        WriteLine($"O ano de {a} é bissexto.");
    }
    else
    {
        WriteLine($"O ano de {a} não é bissexto.");
    }
    return a;
}

int ano;
WriteLine("Digite o ano para descobrir se ele é bissexto ou não:");
ano = Convert.ToInt32(ReadLine());
descobrirAnoBissexto(ano);

// 9 - Calculadora Simples (Switch):

int num1, num2;
string operacao;
WriteLine("Digite o primeiro número:");
num1 = Convert.ToInt32(ReadLine());
WriteLine("Digite o segundo número:");
num2 = Convert.ToInt32(ReadLine());
WriteLine("Digite a operação desejada (+), (-), (*), (/):");
operacao = ReadLine();

switch (operacao)
{
    case "+":
        WriteLine($"Resultado: {num1 + num2}");
        break;
    case "-":
        WriteLine($"Resultado: {num1 - num2}");
        break;
    case "*":
        WriteLine($"Resultado: {num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
        {
            WriteLine($"Resultado: {num1 / num2}");
        }
        else
        {
            WriteLine("Erro: Divisão por zero não é permitida.");
        }
        break;
}

// 10 - Nível de Alerta:

int alerta;
WriteLine("Digite um número entre 1 - 5 para descobrir o nivel de alerta.");
alerta =  (ReadLine());

switch (alerta)
{
      case 1:
        WriteLine("Alerta 1: Nível de Alerta Baixo.");
        break;
    case 2:
        WriteLine("Alerta 2: Nível de Alerta Moderado.");
        break;
    case 3:
        WriteLine("Alerta 3: Nível de Alerta Alto.");
        break;
    case 4:
        WriteLine("Alerta 4: Nível de Alerta Crítico.");
        break;
    case 5:
        WriteLine("Alerta 5: Nível de EMERGÊNCIA.");
        break;
    default:
        WriteLine("Enntrada inválida. Por favor, digite um número entre 1 e 5.");
        break;
}

// 11 - Comparação de Três Números: 

int num1, num2, num3;

WriteLine("Digite o primeiro número: ");
num1 = Convert.ToInt32(ReadLine());
WriteLine("Digite o segundo número: ");
num2 = Convert.ToInt32(ReadLine());
WriteLine("Digite o terceiro número: ");
num3 = Convert.ToInt32(ReadLine());

if (num1 > num2 && num1 > num3)
{
    WriteLine($"O maior número é: {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    WriteLine($"O maior número é: {num2}");
}
else if (num3 > num1 && num3 > num2)
{
    WriteLine($"O maior número é: {num3}");
}
else
{
    WriteLine("Os números são iguais.");
}

// 12 - Verificação de Triângulo

int lado1, lado2, lado3;

Write("Digite o primeiro lado do triângulo: ");
lado1 = Convert.ToInt32(ReadLine());
Write("Digite o segundo lado do triângulo: ");
lado2 = Convert.ToInt32(ReadLine());
Write("Digite o terceiro lado do triângulo: ");
lado3 = Convert.ToInt32(ReadLine());
if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    WriteLine("Os lados formam um triângulo.");
}
else
{
    WriteLine("Os lados não formam um triângulo.");
}

// 13 - Conversão de Nota para Conceito

double nota;
Console.WriteLine("Digite a nota do aluno entre 0 a 10: ");
nota = Convert.ToDouble(ReadLine());

switch (nota)
{
    case <= 4.9:
        Console.WriteLine("D");
        break;
    case >= 5 and <= 6.9:
        Console.WriteLine("C");
        break;
    case >= 7 and <= 8.9:
        Console.WriteLine("B");
        break;
    case >= 9 and <= 10:
        Console.WriteLine("A");
        break;
    default:
        Console.WriteLine("Nota inválida!");
        break;
}

// 14 - Operações com Números Pares/Ímpares:
int calculoNum(int a, int b)
{
    int maior;
    int menor;
    if ((a % 2 == 0) && (b % 2 == 0))
    {
        WriteLine($"Os dois números são pares, portanto devemos somá-los, resultando em {a} + {b} = {a + b}.");
    }
    else if ((a % 2 == 0) && (b % 2 != 0) || (b % 2 == 0) && (a % 2 != 0))
    {
        if (a > b)
        {
            maior = a;
            menor = b;
            WriteLine($"Um dos números é ímpar e o outro par, portanto, devemos subtrair o menor do maior, resultando em:{menor} - {maior} = {menor - maior}.");
        }
        else if (a == b)
        {
            WriteLine($"Como os dois número são iguais, apenas devemos subtrair-los, resultando em: {a} - {b} =  {a - b}.");
        }
        else
        {
            maior = b;
            menor = a;
            WriteLine($"Um dos números é ímpar e o outro par, portanto, devemos subtrair o menor do maior, resultando em: {menor} - {maior} =  {menor - maior}.");
        }
    }
    else
    {
        WriteLine($"Os dois números são ímpares, portanto devemos multiplicar-los, resultando em: {a} X {b} = {a * b}.");
    }
    return a;
}


// 15 - Menu interativo:
int num, num1;
int escolha;
WriteLine("Você tem 3 opções:\n 1 - Soma \n 2 - Subtração \n 3 - Sair");
escolha = Convert.ToInt32(ReadLine());

switch (escolha)
{
    case 1:
        WriteLine("Digite um número para ser somado: ");
        num = Convert.ToInt32(ReadLine());
        WriteLine("Digite outro número para ser somado: ");
        num1 = Convert.ToInt32(ReadLine());
        WriteLine($"A soma dos números {num} + {num1} = {num + num1}.");
        break;
    case 2:
        WriteLine("Digite um número para ser subtraido: ");
        num = Convert.ToInt32(ReadLine());
        WriteLine("Digite outro número para ser subtraido: ");
        num1 = Convert.ToInt32(ReadLine());
        WriteLine($"A subtração dos números {num} - {num1} = {num - num1}.");
        break;
    case 3:
        break;
    default:
        WriteLine("Você digitou algo ou um número inválido, por favor tente novamente.");
        break;
}

ReadLine();
