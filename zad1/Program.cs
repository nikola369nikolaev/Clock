// See https://aka.ms/new-console-template for more information

int hours = int.Parse(Console.ReadLine());
int mins = int.Parse(Console.ReadLine());

mins = mins + 30;

if (mins>=60)
{
    mins = mins - 60;
    hours++;
}

if (hours==24)
{
    hours = 0;
}
Console.WriteLine($"{hours}:{mins:D2}");

