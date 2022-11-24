Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int p = n.ToString().Length;

if (p < 3 || p > 3)
Console.WriteLine("Вы ввели не трехзначное число");

else
{
int n1 = n % 100;
int n2 = n1;
int n3 = n2 / 10;

Console.WriteLine(n3);
}
