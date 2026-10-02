// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello I am \n Ritik"); // \n - moves to a new line
Console.WriteLine("Hello I am \t Ritik"); // It adds a tab space
Console.WriteLine("Hello I am \\ Ritik "); // It prints a literal backslash


// Console.ReadLine()
string favSubject= Console.ReadLine();
Console.WriteLine("Oh I love" + favSubject + "Too");

Console.Write("What is favorite Subject ? ");
string favSub =Console.ReadLine();
Console.WriteLine("Oh it is my" + favSub + "Too");

// Importent point here is Console.ReadLine() always returns a text(string) even if the user types a number. for example
string age = Console.ReadLine();
Console.WriteLine(age + 2);


// STRING CONCATENATION TO  INTERPOLATION 

string fName = "Ritik";
string lastName = "Srivastav";
string message = fName + " " + lastName;
Console.WriteLine(message);

// We can write this program in a better way beaucse if there is more then 2 variables then it gets messy.
string msg = $"My name is {fName} {lastName}";
Console.WriteLine(msg);

Console.Write("What is your profession? ");
string profession= Console.ReadLine();
string myproffesion = profession.ToUpper();
Console.WriteLine($"My name is {fName} and my profession is {myproffesion}");

