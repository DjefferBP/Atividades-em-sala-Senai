using static System.Console;
// DJEFFER BERVIAN PRANGE
// 1- Faça um programa que peça dois números e verifique (usando if e else) e imprima o maior deles.

int n1, n2, maior, menor;
WriteLine("Digite o primeiro número:");
n1 = Convert.ToInt32(ReadLine());
WriteLine("Digite o segundo número:");
n2 = Convert.ToInt32(ReadLine());

if (n1 > n2)
{
    maior = n1;
    menor = n2;
    WriteLine($"O maior número entre eles é o: {maior} e o menor é o: {menor}.");
}
else
{
    maior = n2;
    menor = n1;
    WriteLine($"O maior número entre eles é o: {maior} e o menor é o: {menor}.");
}
WriteLine("\n");
// 2- Faça um programa que leia três números, verifique (usando if e else) e mostre o maior e o menor deles

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
WriteLine("\n");

// 3- Faça um programa para a leitura de duas notas parciais de um aluno.
// ✓ A mensagem “Aprovado”, se a média alcançada for maior ou igual a sete;
// ✓ A mensagem “Aprovado com Distinção”, se a média for igual a dez;
// ✓ A mensagem “Reprovado” se a média for menor de do que sete.

double nota, nota1, media;
Console.WriteLine("Digite a nota do aluno entre 0 a 10: ");
nota = Convert.ToDouble(ReadLine());
Console.WriteLine("Digite a nota do aluno entre 0 a 10: ");
nota1 = Convert.ToDouble(ReadLine());
media = (nota + nota1) / 2;

if (media == 10)
{
    WriteLine("Aprovado com Distinção.");
}
else if (media > 7)
{
    WriteLine("Aprovado");
}
else
{
    WriteLine("Reprovado");
}
WriteLine("\n");

// 4- Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre o mais barato.

double pd, pd1, pd2;

WriteLine("Digite o valor do primeiro produto:");
pd = Convert.ToDouble(ReadLine());
WriteLine("Digite o valor do primeiro produto:");
pd1 = Convert.ToDouble(ReadLine());
WriteLine("Digite o valor do primeiro produto:");
pd2 = Convert.ToDouble(ReadLine());

if ((pd < pd1) && (pd < pd2))
{
    WriteLine($"O produto mais barato para você comprar é o que custa: R${pd}.");
}
else if ((pd1 < pd) && (pd1 < pd2))
{
    WriteLine($"O produto mais barato para você comprar é o que custa: R${pd1}.");
}
else if ((pd2 < pd) || (pd2 < pd1))
{
    WriteLine($"O produto mais barato para você comprar é o que custa: R${pd2}.");
}
else {
        WriteLine($"Os produtos possuem o mesmo preço, pode comprar qualquer um, ou o que possui melhor avaliação.");

}
WriteLine("\n");

// 5- Escreva um programa em C que recebe um inteiro e diga se é par ou ímpar. Use o operador matemático % (resto da divisão ou módulo) e o teste condicional if.
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
WriteLine("\n");

//6- Para doar sangue é necessário ter entre 18 e 67 anos. Faça um aplicativo que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não. Use alguns dos operadores lógicos OU (||) e E (&&).
int filtrarPorIdade(int a)
{
    if (a >= 0 & a <= 12)
    {
        WriteLine($"Você é uma criança, para doar sangue você precisa ter mais de 18 anos..");
    }
    else if (a >= 13 && a <= 17)
    {
        WriteLine($"Você é um adolescente, para doar sangue você precisa ter mais de 18 anos..");
    }
    else if (a >= 18 && a <= 67)
    {
        WriteLine($"Você pode doar sangue! Vá em frente e salve a vida de alguém que futuramente precisará do seu sangue!");
    }
    else if (a >= 68)
    {
        WriteLine($"Você é um idoso, e não pode doar sangue porque tem mais de 68 anos. Pode ser perigoso para você e para os pacientes que irão receber seu sangue! ");
    }
    else
    {
        WriteLine("Você digitou uma entrada inválida, tente novamente.");
    }
    return a;
}

int idade;
WriteLine("Digite sua idade para saber se poderá doar sangue ou não.");
idade = Convert.ToInt32(ReadLine());
filtrarPorIdade(idade);
WriteLine("\n");

// 7- Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B. A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados nas variáveis.

int val, val1;
WriteLine("Digite um valor.");
val = Convert.ToInt32(ReadLine());
WriteLine("Digite outro valor.");
val1 = Convert.ToInt32(ReadLine());
val = val + val1;
val1 = val - val1;
val = val - val1;

WriteLine($"Os valores inseridos com o valor trocado é: {val} e {val1}");
WriteLine("\n");

// 8 - Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor.
double calcularSalario(double sal, int car, double comissao)
{
    double comissaoPorCarro = comissao * car;
    double valVendas = comissaoPorCarro * 0.05;
    double salTotal = sal + comissaoPorCarro + valVendas;
    WriteLine($"Lerite do mês: \nSalário: R${sal} \nCarros vendidos: {car} \nComissao fixa do emprego: {comissao} \nComissão ganha pelos carros vendidos: R${comissaoPorCarro} \n5% do valor das vendas: {valVendas} \nSalário final: R${salTotal}");
    return salTotal;
}
double salario, comissaoFixa;
int carrosVendidos;

WriteLine("Digite abaixo qual o salário do funcionário: ");
salario = Convert.ToDouble(ReadLine());
if (salario < 1518){
  WriteLine("O salário do funcionário é menor que o salário mínimo, portanto, este salário é inválido. ");
  do {
    WriteLine("Digite abaixo o salário correto: ");
    salario = Convert.ToDouble(ReadLine());
} while (salario < 1518);
WriteLine("Digite abaixo quantos carros o funcionário vendeu: ");
carrosVendidos = Convert.ToInt32(ReadLine());
WriteLine("Digite abaixo qual o valor da comissão fixa por carro vendido: ");
comissaoFixa = Convert.ToDouble(ReadLine());
calcularSalario(salario, carrosVendidos, comissaoFixa);
WriteLine("\n");

// 9 - Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius

double calcularCelcius(double a)
{
    double emCelsius = (a - 32) * 5 / 9  ;
    WriteLine($"A temperatura em  F°{a} em Celcius é: C°{Math.Round(emCelsius, 0)} graus.");
    return a;
}

double fahrenheits;
WriteLine("Digite a temperatura em Fahrenheit para descobrir o valor dela em Graus Celcius");
fahrenheits = Convert.ToDouble(ReadLine());
calcularCelcius(fahrenheits);
WriteLine("\n");

// 10 - Faça um algoritmo que transforme uma velocidade fornecida em m/s pelo usuário para Km/h. Para tal, multiplique o valor em m/s por 3,6.

double transformarVelocidade(double a)
{
    double velocidadeConvertidaParaKm = a * 3.6;
    WriteLine($"A velocidade {a}m/s em km/h é {Math.Round(velocidadeConvertidaParaKm, 2)}km/h.");
    return velocidadeConvertidaParaKm;
}

double velocidade;
WriteLine("Digite uma velocidade em m/s para descobrir ela em km/h.");
velocidade = Convert.ToInt32(ReadLine());
transformarVelocidade(velocidade);

ReadLine();
