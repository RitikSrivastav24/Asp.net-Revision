//int tbl = 2;
//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{tbl} * {i} == {tbl * i}");

//}
//Console.ReadLine(); 


//for (int  i =1; i<=10; i++)
//{
//    for(int j=1; j<=10; j++)
//    {
//        Console.WriteLine($"{i} * {j} == {i * j}");
//    }
//}
//Console.ReadLine(); 

//Console.Write("Enter a Number: ");
//string input = Console.ReadLine();
//if(int.TryParse(input, out int num))
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{num} * {i} = {num * i}");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

//Console.Write("Enter a number: ");
//string input = Console.ReadLine();
//Console.Write("Enter the range: ");
//string rangeInput = Console.ReadLine();
//if(int.TryParse(input, out int number))
//{

//    if(int.TryParse(rangeInput,out int range))
//    {
//        for(int i=1; i<=range; i++)
//        {
//            Console.WriteLine($"{number} * {i} = {number * i}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid range input. Please enter a valid number.");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid number input. Please enter a valid number.");
//}




//------------- while loop ---------------- 

//int i = 10;
//while(i>=1)
//{
//    Console.WriteLine($"The value of i is: {i}");
//    i--;
//}

//Console.Write("Enter a number: ");
//string input = Console.ReadLine();
//if(int.TryParse(input, out int num))
//{
//    while(num >= 1)
//    {
//        Console.WriteLine($"{num}");
//        num--;
//    }
//}
//else
//{
//       Console.WriteLine("Invalid input. Please enter a valid number.");
//}

//Console.Write("Enter a number: ");
//string input = Console.ReadLine();
//Console.Write("Enter the range: ");
//string rangeInput = Console.ReadLine();

//if(int.TryParse(input, out int number) && int.TryParse(rangeInput, out int range))
//{
//    int i = 1;
//    while(i <=range)
//    {
//        Console.WriteLine($"{number} * {i}= {number * i}");
//        i++;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter valid numbers.");
//}




//--------------- do while loop ----------------

//int i = 1;

//do
//{
//    Console.WriteLine($"{i}");
//    i++;
//}

//while (i <= 5);

//int num;
//do
//{
//    Console.Write("Enter a number");
//    num = Convert.ToInt32(Console.ReadLine());

//    if (num < 0)
//    {
//        Console.WriteLine("Please enter a positive number");
//    }
//}
//while (num < 0);
//Console.WriteLine($"You entered: {num}");

int age;

do
{
    Console.Write("Enter your age: ");
    age = Convert.ToInt32(Console.ReadLine());

    if (age < 18)
    {
        Console.WriteLine("You are not eligible to vote. Please enter a valid age.");
    }
}
while (age < 18);
Console.WriteLine($"You are eligible");