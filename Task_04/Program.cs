System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = -n;
int x = count % 2;
while (count <= n)
{
    if (count < 0)
    {
       count = count + 1; 
    }
    if (x == 0)
    {
        Console.Write($"{count}, ");
        count = count + 1;       
    }
    else
    {
       count = count + 1; 
    }
}