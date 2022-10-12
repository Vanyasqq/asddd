// int randomValue = new Random().Next(100,1000);
// Console.WriteLine(randomValue);

// int two_num = randomValue % 100 / 10;

Console.WriteLine("Ведите трехзначное число");
int number = int.Parse(Console.ReadLine());
int two_num = number % 100 / 10;
Console.WriteLine(two_num);