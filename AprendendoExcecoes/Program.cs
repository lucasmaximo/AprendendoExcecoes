// See https://aka.ms/new-console-template for more information

try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;
    Console.WriteLine(result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Divisão por zero não permitida!");
}
catch (FormatException e)
{
    Console.WriteLine("Formato errado!" + e.Message);
}
finally
{
    Console.WriteLine("Executa de qalquer forma, independentemente de ter ocorrido uma exceção ou não.");
}