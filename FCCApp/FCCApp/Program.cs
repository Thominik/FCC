#region tabs
//var grades = new int[365];

//var dayOfWeeks = new string[7];

//dayOfWeeks[0] = "poniedziałek";
//dayOfWeeks[1] = "wtorek";
//dayOfWeeks[2] = "środa";
//dayOfWeeks[3] = "czwartek";
//dayOfWeeks[4] = "piątek";
//dayOfWeeks[5] = "sobota";
//dayOfWeeks[6] = "niedziela";


//foreach (var dayOfWeek in dayOfWeeks)
//{
//    Console.WriteLine(dayOfWeek);
//}

//for (var i = 0; i < 7; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//for (var i = 0; i < dayOfWeeks.Length; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

#endregion

#region lists

//List<string> dayOfWeeks = new List<string>();
//dayOfWeeks.Add("poniedziałek");
//dayOfWeeks.Add("wtorek");
//dayOfWeeks.Add("środa");
//dayOfWeeks.Add("czwartek");
//dayOfWeeks.Add("piątek");
//dayOfWeeks.Add("sobota");
//dayOfWeeks.Add("niedziela");

//for (var i = 0; i < dayOfWeeks.Count; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//foreach (var dayOfWeek in dayOfWeeks)
//{
//    Console.WriteLine(dayOfWeek);
//}

#endregion

#region homework

int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();


int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;
int counter10 = 0;

foreach (char c in letters)
{
    if (c == '0')
        counter1++;
    else if (c == '1')
        counter2++;
    else if (c == '2')
        counter3++; 
    else if (c == '3')
        counter4++;
    else if (c == '4')
        counter5++;
    else if (c == '5')
        counter6++;
    else if (c == '6')
        counter7++;
    else if (c == '7')
        counter8++;
    else if (c == '8')
        counter9++;
    else if (c == '9')
        counter10++;
}

Console.WriteLine($"Wynik dla liczby: {number}");
Console.WriteLine($"0 => {counter1}");
Console.WriteLine($"1 => {counter2}");
Console.WriteLine($"2 => {counter3}");
Console.WriteLine($"3 => {counter4}");
Console.WriteLine($"4 => {counter5}");
Console.WriteLine($"5 => {counter6}");
Console.WriteLine($"6 => {counter7}");
Console.WriteLine($"7 => {counter8}");
Console.WriteLine($"8 => {counter9}");
Console.WriteLine($"9 => {counter10}");

#endregion