//class Employee
//{
//    public string Name= "Ritik";

//    public void Work()
//    {
//        Console.WriteLine("Employee is Working");
//    }
//}

//class Developer : Employee
//{
//    public void Code()
//    {
//        Console.WriteLine("Developer is coding");
//    }
//}

//class program
//{
//    static void Main()
//    {
//        Developer dev= new Developer();
//        Console.WriteLine(dev.Name);
//        dev.Work();
//        dev.Code();
//    }
//}


//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; } 
//    public void Work()
//    {
//        Console.WriteLine("Employee is Working");
//    }
//}

//class Developer : Employee
//{
//    public void showDetails()
//    {

//        Console.WriteLine(Name);
//        Console.WriteLine(Salary);
//    }
//    public void Code()
//    {
//        Console.WriteLine("Developer is coding");
//    }
//}

//class program
//{
//    static void Main()
//    {
//        Developer dev = new Developer();
//        dev.Name = "Ritik";
//        //dev.Salary = 50000;
//        Console.WriteLine(dev.Name);
//        dev.Work();
//        dev.Code();
//        dev.showDetails();
//    }
//}


// Inheritance Constructor in c#
//class Student
//{
//    public Student(string name)
//    {
//        Console.WriteLine($"Student Constructor : {name}");
//    }
//}

//class Subject : Student
//{
//    public Subject(string name) : base(name)
//    {
//        Console.WriteLine($"Subject Constructor : {name}");
//    }

//}

//class Program
//{
//    static void Main()
//    {
//        Subject sub = new Subject("Ritik");

//    }
//}

/* 
Subject(string name) is the child class constructor.
base(name) calls the parent class constructor, passing the value of name.
"Ritik" is passed when we create the Subject object.
The parent constructor executes before the child constructor's body.
*/


class Employee
{
    public Employee(string name)
    {
        Console.WriteLine($"Employee Constructor : {name}");
    }
}

class Developer : Employee
{
    public Developer(string name): base(name)
    {
        Console.WriteLine("Developer Constructor is Created!");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Developer dev = new Developer("Nitin");
//    }
//}


/*but what happens when we don't inherit the parent constructor 
class Employee1
{
    public Employee1(string name)
    {
        Console.WriteLine($"Employee Constructor : {name}");
    }
}

class Developer1 : Employee1
{
    public Developer1(string name) 
    {
        Console.WriteLine("Developer Constructor is Created!");
    }
}

class Program1
{
    static void Main()
    {
        Developer1 dev = new Developer1("Nitin");
    }
}

Ans is it will give a compile time error because Employee1 has only 1 constructor and it requires a string 
parameter.When we omit :base(name), C# automatically tries to call the parent's parameterless constructor
 equivalent to base().But Employee1() does not exist. Therefore, the code produces a compile-time error.
*/


/* Constructor Chaining with base() 

class Employee2
{
    public string Name;
    public Employee2(string name)
    {
        Name = name;
        Console.WriteLine("Employee Constructor " + name);
    }
}

class Developer2: Employee2
{
    public Developer2(string name) : base(name)
    {

        Console.WriteLine("Developer Constructor" + name);

    }

    public void ShowDetails()
    {
        Console.WriteLine(Name);
    }
}


class Program
{
    static void Main()
    {
        Developer2 dev = new Developer2("Ritik");
        dev.ShowDetails();
    }
}
Here, base(name) passes the constructor argument to Employee, where it is assigned to the inherited Name field.
*/