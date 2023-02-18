
using System.Globalization;

int counter = 0;
int k = 0;
int lenght;
int j;

Console.Write("Enter lenght massive: ");
lenght = int.Parse(Console.ReadLine());

string[] mass = new string[lenght];

while (lenght > k)
{
    Console.WriteLine("enter " + k + " element of massive");
    mass[k] = Console.ReadLine();
    k++;
}

for (int i = 0; mass.Count() > i; i++)
{
    if (mass [i].Length <= 3)
    {
        counter++;
    }
}
Console.WriteLine("Count elements lower then 3: " + counter);
