// Calculation
int firstNum = 12;
int secNum = 8;
int sum = firstNum + secNum;
Console.WriteLine($"Sum: {sum}");

// convert types
firstNum = 7;
secNum = 5;
decimal quotient = (decimal)firstNum / (decimal)secNum;
Console.WriteLine(quotient);

// increment and decrement
int value = 0;  // 0 
value = value + 5;  // 5
value += 5; // 10
value++; // 11
Console.WriteLine(value);

value = 1;
value = value + 1;
Console.WriteLine(value);
value += 1;
Console.WriteLine(value);
value++;
Console.WriteLine(value);
value = value - 1;
Console.WriteLine(value);
value -= 1;
Console.WriteLine(value);
value--;
Console.WriteLine(value);

Console.WriteLine("");
Console.WriteLine("");

// CHALLENGE
int fahrenheit = 94;
decimal celsius = ((decimal)fahrenheit - 32m)*(5m/9m);
decimal rounded = Math.Round(celsius, 2);
Console.WriteLine($"The temperature is {rounded} Celsius");

Console.WriteLine(5/10);
int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);