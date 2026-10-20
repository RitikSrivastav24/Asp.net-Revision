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


using System.Xml.Linq;

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


/* ** base() vs base.mathodname
 * 
 * class Employee3
{
    public string Name;
    public Employee3(string name)
    {
        Name = name;
        Console.WriteLine($"Employee {name}");
    }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer3 : Employee3
{
    public Developer3(string name): base(name)
    {
        Console.WriteLine("Developer Created");
    }

    public override void Work()
    {
        base.Work();
        Console.WriteLine("Developer is coding");
    }
}

class Program
{
    static void Main()
    {
        Developer3 dev3 = new Developer3("Ritik");
        dev3.Work();
    }
} */


// Sealed 
//class Employee4
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("Employee");
//    }
//}
//class Developer4 : Employee4
//{
//    public sealed override void Work()
//    {
//        Console.WriteLine("Developer is created");
//    }
//}

//class SeniorDeveloper : Developer4
//{
//    public override void Work()  // It will give comnpile time error because work is sealed in developer. but if we remove work just inherit developer class without work method then it will not give error because only work is sealed. We can also whole class. 
//    {

//    }
//}


//Create an Employee class with a protected field Name.
//Add a constructor that accepts a name and assigns it to Name.
//Add a virtual method Work() that prints Employee is working.
//Create a Developer class that inherits from Employee.
//Call the parent constructor using base(name).
//Override Work() to print Developer is coding, then call base.Work().
//In Main(), create an Employee reference pointing to a Developer object.
//Call Work() through that reference.

class Employee5
{
    protected string Name;
    public Employee5(string name)
    {
        Name = name;
    }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer5 : Employee5
{
    public Developer5(string name) : base(name)
    {
        Console.WriteLine("Developer Created");
    }

    public override void Work()
    {
        Console.WriteLine("Developer is Coding");
        base.Work();
    }
}

class Program
{
    static void Main()
    {
        Employee5 emp5 = new Developer5("Ritik");
        emp5.Work();
    }
}