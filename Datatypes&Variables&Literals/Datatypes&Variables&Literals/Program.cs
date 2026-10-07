using System.Runtime.CompilerServices;

int i=4;
double d = i; // Implicit conversion from int to double
// Console.WriteLine(d);
double x = 78.7;
// int y = x; // Error: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
int y= (int)x; // Explicit conversion from double to int
//Console.WriteLine(y); 

double a = 25.75;
int b = (int)a;
// Console.WriteLine(b);

int c = 25;
double e = c;
// Console.WriteLine(e);


// convert
string age= Console.ReadLine();
//int ageInt= Convert.ToInt32(age);
//00Console.WriteLine(ageInt + 2);

//double f = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(f + 87);

//Console.Write("Enter a number ");
//string input= Console.ReadLine();
//Console.WriteLine($"You have entered {input}");
//double num = Convert.ToDouble(input);
//Console.WriteLine(num + 5);


int salary = 24000;
if(salary>20000)
{
    Console.WriteLine("You are eligible for a loan");
}
else
{
       Console.WriteLine("You are not eligible for a loan");
}

//Console.Write("Enter your Employee Code");
//int empCode = Convert.ToInt32(Console.ReadLine());
//if(empCode == 1234)
//{
//    Console.WriteLine("Welcome to the dashboard");
//}
//else
//{
//       Console.WriteLine("Invalid Employee Code");
//}

//Console.Write("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 2 == 0)
//{
//    Console.WriteLine("The number is even");
//}
//else
//{
//    Console.WriteLine("The number is odd");
//}




// Try Parse  -- It tries to convert into an int if it's successful it returns true else false
Console.Write("Enter your EmpCode: ");
string empCodeInput = Console.ReadLine();

if (int.TryParse(empCodeInput, out int empCode)) // in this out means that the value of empCode will be assigned if the parsing is successful
{
    if (empCode == 1234)
    {
        Console.WriteLine("You are a valid employee");
    }
    else
    {
        Console.WriteLine("You are not a valid employee");
    }
}
else
{
    Console.WriteLine("Please Enter a Valid Input");
}