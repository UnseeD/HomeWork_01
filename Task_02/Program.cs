System.Console.WriteLine("Enter A: ");
int numA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter B: ");
int numB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter C: ");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if (max < numB)
{
    max = numB;
}
if (max < numC)
{
   max = numC;
}

System.Console.WriteLine($"Ответ: {max}");
