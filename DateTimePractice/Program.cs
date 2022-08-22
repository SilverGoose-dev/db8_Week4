DateTime time1 = new DateTime(2022, 07, 31);
Console.WriteLine(time1.ToString("yyyy-MMM-dd"));

DateTime time2 = DateTime.Now;
Console.WriteLine(time2);

DateTime time3 = DateTime.Parse("7/09/2022 11:30am");
Console.WriteLine(time3.ToShortDateString());



