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



//int age;
//do
//{
//    Console.Write("Enter your age: ");
//    age = Convert.ToInt32(Console.ReadLine());

//    if (age < 18)
//    {
//        Console.WriteLine("You are not eligible to vote. Please enter a valid age.");
//    }
//}
//while (age < 18);
//Console.WriteLine($"You are eligible");



// Use a while loop to print numbers from 20 to 1.
//int i = 20;
//while(i >= 1)
//{
//    Console.WriteLine($"{i}");
//    i--;
//}


//Use a for loop to print all even numbers from 1 to 50.
//for(int i=1; i<=50; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine($"{i}");
//    }
//}

// Use a while loop to print all odd numbers from 1 to 50.

//int i = 1;
//while (i <= 50)
//{
//    if(i % 2 ==1 )
//    {
//        Console.WriteLine($"{i}");

//    }
//    i++;
//}


// Ask the user for a number and range, then print its table using while.
//Console.WriteLine("Enter a Number: ");
//string input  = Console.ReadLine();
//Console.WriteLine("Enter a Range");
//string rangeInput=Console.ReadLine();

//if(int.TryParse(input, out int num) && int.TryParse(rangeInput, out int range))
//{
//    int i = 1;
//    while(i <= range)
//    {
//        Console.WriteLine($"{num} * {i} = {num * i}");
//        i++;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid Input");
//}


// Ask the user for a positive number n and calculate:
//Console.Write("Enter a number: ");
//string input = Console.ReadLine();
//if(int.TryParse(input, out int n)){
//    int a = n * (n + 1) / 2;
//        if(a > 0)
//        Console.WriteLine($"The sum of your number is {a}");
//    }
//else
//{
//       Console.WriteLine("Invalid input. Please enter a valid number.");
//}




// Ask for a number and calculate its factorial.

//Console.Write("Enter a number: ");
//string input = Console.ReadLine();
//if (int.TryParse(input, out int factorial))
//{
//    int fact = 1;
//    int i = 1;
//    while(i <= factorial)
//    {
//        fact= fact* i;
//        i++;
//        Console.WriteLine($" {fact}");
//    }

//}
//else      
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}    


// Use do-while to keep asking the user for a number until they enter a number greater than 0.

//int number;

//do
//{
//    Console.Write("Enter a Positive Number: ");
//    number=Convert.ToInt32(Console.ReadLine());

//    if(number < 0)
//    {
//        Console.WriteLine("Please enter a positive number");
//    }

//}
//while(number < 0);
//Console.WriteLine($"You entered: {number}");


// Keep asking the user to guess until they get it correct.

//int secretNum = 5;
//int guessNum;
//do
//{
//    Console.Write("Guess the secret number (between 1 and 10): ");
//    guessNum= Convert.ToInt32(Console.ReadLine());

//    if (guessNum != secretNum)
//    {
//        Console.WriteLine("You are wrong");
//    }
//}
//while (guessNum != secretNum);
//Console.WriteLine("You are correct!");


// Ask the user for a number and reverse it.

//Console.WriteLine("Enter a Number: ");
//string input = Console.ReadLine();

//if(int.TryParse(input, out int numbers) && numbers >=10 && numbers <= 999)
//{
//    int reversed = 0;
//    while(numbers > 0)
//    {
//        int revNum = numbers % 10;
//        reversed = (reversed * 10) + revNum;
//        numbers = numbers / 10;
//    }
//    Console.WriteLine($"Reverse  number is {reversed}");
//}
//else
//{
//       Console.WriteLine("Invalid input. Please enter a valid number between 10 and 999.");
//}


// Create a calculator that keeps running until the user chooses Exit.




// -----------  Switch Case ---------------

//int choice = 2;

//switch(choice)
//{
//    case 1:
//        Console.WriteLine("You choose 1");
//        break;
//    case 2:
//        Console.WriteLine("You choose 2");
//        break;
//    case 3: 
//        Console.WriteLine("You choose 3");
//        break;
//    default:
//        Console.WriteLine("Inavild Choice");
//        break;
//}

//Console.Write("Enter a number between 1 and 7: ");
//uint day = Convert.ToUInt32(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid Input");
//        break;
//}



bool a = true;

do
{
    Console.Clear();
    Console.WriteLine("-- -- Calculator Menu -----");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    string choose = Console.ReadLine();
    if (int.TryParse(choose, out int choice))
    {
        Console.WriteLine($"You have chosen option {choice}");

        switch (choice)
        {
            case 1:
                int addnum1, addnum2,  addresult;
                Console.WriteLine("You have chosen Addition");
                Console.Write("Enter the first number: ");
                addnum1= int.TryParse(Console.ReadLine(), out addnum1) ? addnum1 : 0;
                Console.Write("Enter the second number: ");
                addnum2 = int.TryParse(Console.ReadLine(), out addnum2) ? addnum2 : 0;
                addresult = addnum1 + addnum2;
                Console.WriteLine($"The result of {addnum1} + {addnum2}  = {addresult}");
                break;
            case 2:
                int subnum1, subnum2, subresult;
                Console.WriteLine("You have chosen Subtraction");
                Console.Write("Enter the first number: ");
                subnum1 = int.TryParse(Console.ReadLine(), out subnum1) ? subnum1 : 0;
                Console.Write("Enter the second number: ");
                subnum2 = int.TryParse(Console.ReadLine(), out subnum2) ? subnum1 : 0;
                subresult = subnum1 - subnum2;
                Console.WriteLine($"The result of {subnum1} - {subnum2}  = {subresult}");
                break;
            case 3:
                int mnum1, mnum2, mresult;
                Console.WriteLine("You have chosen Multiplication");
                Console.Write("Enter the first number: ");
                mnum1 = int.TryParse(Console.ReadLine(), out mnum1) ? mnum1 : 0;
                Console.Write("Enter the second number: ");
                mnum2 = int.TryParse(Console.ReadLine(), out mnum2) ? mnum2 : 0;
                mresult = mnum1 * mnum2;
                Console.WriteLine($"The result of {mnum1} * {mnum2}  = {mresult}");
                break;
            case 4:
                int dnum1, dnum2, dresult;
                Console.WriteLine("You have chosen Division");
                Console.Write("Enter the first number: ");
                dnum1 = int.TryParse(Console.ReadLine(), out dnum1) ? dnum1 : 0;
                Console.Write("Enter the second number: ");
                dnum2 = int.TryParse(Console.ReadLine(), out dnum2) ? dnum2 : 0;
                if(dnum2 ==0 )
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                }
                dresult = dnum1 / dnum2;
                Console.WriteLine($"The result of {dnum1} / {dnum2}  = {dresult}");
                break;
            case 5:
                Console.WriteLine("Exiting the calculator. Goodbye!");
                a = false; 
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                a = false;
                break;
        }

    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    if (a)
    {
        Console.WriteLine("\n Press any key to return to the menu...");
        Console.ReadKey();
    }
}
while (a);