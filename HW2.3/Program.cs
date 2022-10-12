Console.WriteLine("Введите цифру, обозначающую день недели!");
int number_week = int.Parse(Console.ReadLine());

if(number_week < 6)
{
    Console.WriteLine(number_week + ", этот день не является выходным");
}
else
{
    Console.WriteLine(number_week + ", Выходный день");
}