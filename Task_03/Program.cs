System.Console.Write("Введите четное число: ");
int n = int.Parse(Console.ReadLine());
int x = n%2;
if (x==0)
{
    System.Console.WriteLine("Ваше число четное.");
}
else
{
    System.Console.WriteLine("Вы ввели не четное число.");
}
