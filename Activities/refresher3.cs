// Character escape '\' is used to insert a special character that will affect the string output
// \n will add a new line
// \t will add a tab
Console.WriteLine("Hello \nWorld");
Console.WriteLine("Hello \tWorld");
// to insert a double quotation mark
Console.WriteLine("Hello \"World\"!");
// to display file paths r use \ in strings
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("");

// prac
Console.WriteLine("Generating invices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// added
Console.WriteLine(@"c:\invoices");

Console.WriteLine("");

// Verbatim string literal
// use @ to keep all whitespace and characters without the need to use \
// Console.WriteLine(@"    c:\source\repos
//         (this is where your code goes)");

// unicode escape characters \u
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// Kon'nichiwa World!

Console.WriteLine("");

// To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


Console.WriteLine("");
Console.WriteLine("");

// String concatenation
string firstname = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstname + "!";
Console.WriteLine(message);

// string interpolation
message = $"Hello {firstname}!";
Console.WriteLine(message);

Console.WriteLine("");
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");
Console.WriteLine("");

// verbatim + interpolation
string projectName = "First Project";
Console.WriteLine($@"c:\Output\{projectName}\Data");
Console.WriteLine("");
Console.WriteLine("");

// CHALLENGE
projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English Output:
    c:\Exercise\{projectName}\data.txt"
        
        );

Console.WriteLine($@"
{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");