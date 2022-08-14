Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine();
void CheckingNumber(string a)
{
if(a[0]== a[4] || a[1]== a[3])
{
    Console.WriteLine($"{a} - Да.");
}
else
{
    Console.WriteLine($"{a} - Нет.");
}
}
if(a!.Length == 5)
{
    CheckingNumber(a);
}