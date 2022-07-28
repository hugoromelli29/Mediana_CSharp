Begin: Console.WriteLine("Deseja calcular a mediana de uma amostra de quantos números?");
int qtd = int.Parse(Console.ReadLine());

Array amostra = Array.CreateInstance(typeof(double), qtd);

for (int i = 0; i < amostra.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    amostra.SetValue(double.Parse(Console.ReadLine()), i);
}

TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array está vazio");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = 0;
    if (tamanho % 2 != 0)
    {
        mediana += numerosOrdenados[meio];
    }
    else if (tamanho % 2 == 0)
    {
        mediana += (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    }
    Console.WriteLine($"Mediana = {mediana}");
}

Console.ReadKey();
Console.Clear();
goto Begin;