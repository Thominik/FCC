var name = "Ewa";
bool isMan = false;
var age = 33;

if (isMan == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" &&  age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isMan == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Podaj inne dane");
}