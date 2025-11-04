int firstPlayer;
int secondPlayer;
int maximum;
int possibilities;

firstPlayer = Convert.ToInt32(Console.ReadLine());
secondPlayer = Convert.ToInt32(Console.ReadLine());

if (firstPlayer >= secondPlayer)
    maximum = firstPlayer;
else 
    maximum = secondPlayer;

possibilities = 6 - maximum + 1;

Console.WriteLine(possibilities);
Console.WriteLine(maximum);

if (possibilities == 0 || possibilities == 1)
    Console.WriteLine(possibilities + "/1");

else
{
    if (6 % Possibilities == 0)
        Console.WriteLine("1/"+ (6/Possibilities));
    else
        Console.WriteLine(Possibilities+"/6");
}