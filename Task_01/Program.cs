System.Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
if (numA > numB)
{
    System.Console.WriteLine($"max = {numA} ");
}
else 
{
    System.Console.WriteLine($"max = {numB} ");
}