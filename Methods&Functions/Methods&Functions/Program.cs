using System;

//class Program
//{
//    static void Main()
//    {
//        sayHello();
//    }

//    static void sayHello() // Static allow us to call the method directly from Main() without creating a program object in this example.
//                           // void means it does not return a value to the caller.
//                           // sayHello() method name
//                           // () it contains parameters.but this methiod has none
//                           // {} The method body: the code that runs when the method is called.
//    {
//        // Console.WriteLine("This is the about Methods"); // Method is a reusable block of code that performs a patricular task.
//    }
//}

//class Program1
//{
//    static void Main()
//    {
//        //ShowMenu();
//        ShowMenu("Ritik");
//        ShowMenu("Nitin");
//    }

//    //static void ShowMenu()
//    //{
//    //    Console.WriteLine("Welcome to C# Learning");
//    //    Console.WriteLine("1. Start Learning");
//    //    Console.WriteLine("2. Exit");
//    //}

//    static void ShowMenu( string name)
//    {
//        Console.WriteLine($"Welcome to C# Learning {name}");
//        Console.WriteLine("1. Start Learning");
//        Console.WriteLine("2. Exit");
//    }
//}


//class Program3
//{
//    static void Main()
//    {
//        int result = Multiply(4, 6);
//        Console.WriteLine(result);
//    }

//    static int Multiply(int a, int b)
//    {
//        return a * b;
//    }
//}

//class Program4
//{
//    static void Main()
//    {
//        int Producu1 = Product(10, 20);
//        int Product2 = Product(10, 20, 30);
//        // This is called Method overloading, creating multiple methods with same but having different parameters.
//        Console.WriteLine(Producu1);
//        Console.WriteLine(Product2);
//    }

//    static int Product(int x, int y)
//    {
//        return x * y;
//    }

//    static int Product(int x, int y, int z)
//    {
//        return x * y * z;
//    }
//}

//class Program5
//{
//    static void Main()
//    {
//        int result = Subtract(15, 7);
//        Console.WriteLine(result);
//    }

//    static int Subtract(int x, int y) 
//    {
//        return x - y;
//    }
//} 

class Calculator
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter First Number: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        if(!int.TryParse(Console.ReadLine(), out  a)){
             Console.WriteLine("Inavalid first number");
            return;
        }
        Console.WriteLine("Enter Second Number: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        if (!int.TryParse(Console.ReadLine(), out  b))
        {
            Console.WriteLine("Invalid Second Number");
            return;
        }
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Choose operation: ");

        //int choice = Convert.ToInt32(Console.ReadLine());
        if(!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid Choice");
            return;
        }
        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine(Add(a, b));
                    break;
                }
            case 2:
                {
                    Console.WriteLine(Subtract(a, b));
                    break;
                }
            case 3:
                {
                    Console.WriteLine(Multiply(a, b));
                    break;
                }
            case 4:
                {
                    if(b == 0)
                    {
                        Console.WriteLine("Division by 0 is not allowed!");
                    }
                    else {
                        Console.WriteLine(Divide(a, b));
                        
                    }
                    break;

                }
            default:
                {
                    Console.WriteLine("Invalid");
                    break;
                }
        }
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int num= Convert.ToInt32(Console.ReadLine());

//        bool result = Convert.ToBoolean(isEven(num));
//        Console.WriteLine(result);
//    }
//    static bool isEven(int a)
//    {
//        return a % 2 == 0 ? true : false;
//    }
//}