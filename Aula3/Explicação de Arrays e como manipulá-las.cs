using static System.Console;
// Aula 10/04/2025 - Arrays
// Em C#, um array é uma coleção de elementos do mesmo tipo, usada para armazenar e acessar dados de forma organizada. Cada elemento em um array é acessado por um índice numérico, e os arrays têm um tamanho fixo quando são criados. 

// Aprendendo como declarar arrays, conhecendo arrays e índex, usando loops para percorrer o array, trocando valores existentes no array, usando Sort para organizar a lista em  ordem alfabética.
/*
string[] carros = { "Volvo", "Peugeot", "Nissan" };
carros[2] = "Opala";
WriteLine("percorrendo a array com for");
for (int i = 0; i < carros.Length; i++)
{
    WriteLine($"{i + 1} = {carros[i]}");
}
WriteLine("\n");
WriteLine("percorrendo a array com foreach");
carros[1] = "Chevrolet";
foreach (string i in carros)
{
    WriteLine(i);
}
WriteLine("\n");
WriteLine("Lista organizada em ordem alfabetica:");
Array.Sort(carros);
for (int i = 0;i < carros.Length; i++)
{
    WriteLine(carros[i]);
}
WriteLine("\n");
WriteLine("Transoformando em lista para depois criar uma nova marca de carro e passar para array novamente.");
string novamarca = "Toyota";
List<string> novoCarros = new List<string>(carros.ToList());
novoCarros.Add(novamarca);
carros = novoCarros.ToArray();
Array.Sort(carros);
foreach (string i in carros)
{
    WriteLine(i);
}
