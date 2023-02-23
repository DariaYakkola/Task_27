Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string array = number.ToString();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
  int result = int.Parse(char.ToString(array[i]));
  sum = sum + result;
}
Console.WriteLine($"Cумма цифр в числе {number} равна {sum} ");