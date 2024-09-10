int thisYear = int.Parse(Console.ReadLine()) ;
int year = int.Parse (Console.ReadLine());


if (year == thisYear)
{
    Console.WriteLine(year+"is this year");
}
else if (year < thisYear)
{
    Console.WriteLine("we are in the past");
}
else
{
    Console.WriteLine("we are in future");
}
