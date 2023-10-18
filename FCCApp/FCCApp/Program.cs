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

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

//for (var i = 0; i < dayOfWeeks.Count; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

foreach (var dayOfWeek in dayOfWeeks)
{
    Console.WriteLine(dayOfWeek);
}

#endregion