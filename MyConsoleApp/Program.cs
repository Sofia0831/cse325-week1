// See https://aka.ms/new-console-template for more information
var datenow = DateTime.Now;
var future = new DateTime(2026, 12, 25);
var numofDays = (future - datenow).Days;

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");
Console.WriteLine($"There are {numofDays} days until the next Christmas");
