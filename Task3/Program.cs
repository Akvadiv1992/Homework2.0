Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблись!\nВведите день недели: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.Write("Понедельник - нет");
else if (n == 2)
Console.Write("Вторник - нет");
else if (n == 3)
Console.Write("Среда - нет");
else if (n == 4)
Console.Write("Четверг - нет");
else if (n == 5)
Console.Write("Пятница - нет");
else if (n == 6)
Console.Write("Суббота - да");
else
Console.Write("Воскресенье - да");