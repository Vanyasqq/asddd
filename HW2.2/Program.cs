int randomValue = new Random().Next(8,100000);
Console.WriteLine(randomValue);

string strRandom = randomValue.ToString();

if(strRandom.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
   Console.WriteLine(strRandom[2]); 
}



