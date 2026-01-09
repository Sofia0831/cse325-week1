// char literal
Console.WriteLine('b');
// error too many char literals
// Console.WriteLine('Hello World');
// the compiler expects only a single character when using ''
// use char when u have a single alphanumerical character for presentation NOT calculation

// int literals
Console.WriteLine(123);

// float literals
// float ~6-9 digits
// double ~15-17 digits
// decimal ~28-29 digits
Console.WriteLine(0.25f);
// f or F is a literal suffix it tells the compiler you are wrking with float types
Console.WriteLine(2.625);
// for double just enter the number as a decimal
Console.WriteLine(12.39816m);
// m is the suffix for decimals

// boolean literals
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine("");


// DECLARING VARIABLES
// data type then the name
// string firstName;
// this will only hold string values
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

// assigning value to variables and retrieving it
string firstName = "Bob";
Console.WriteLine(firstName);
// Reassigning value
firstName = "Yelena";
Console.WriteLine(firstName);
firstName = "Ava";
Console.WriteLine(firstName);
firstName = "John";
Console.WriteLine(firstName);
firstName = "Alexei";
Console.WriteLine(firstName);
firstName = "Bucky";
Console.WriteLine(firstName);

// implicitly typed local variables
var message = "Hello World";
// var tells the compiler that the data type is implied by the assigned value
// it is used to save on keystrokes when types are lengthy or obvious from context
// because mesage is set to a string it can never be changed
// message = 10; will result in an error
// var must also be immediately initialized


// CHALLENGE
var name = "Bob";
var num = 3;
var temp = 34.4;

Console.WriteLine($"Hello, {name}! You have {num} messages in your inbox. The temperature is {temp} celsius.");