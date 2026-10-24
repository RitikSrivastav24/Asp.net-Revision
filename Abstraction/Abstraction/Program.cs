//// Abstraction
//class Employee
//{
//    public int EmpId;
//    public string Name;
//    public double Grossay;
//    double Tax = 0.1;
//    double NetSalary;

//    public Employee(int Eid, string Ename, double EGrossay)
//    {
//        EmpId = Eid;
//        Name = Ename;
//        Grossay = EGrossay;
//    }

//    void CalculateSalary()
//    {
//        if(Grossay > 35000)
//        {
//            NetSalary = Grossay - (Tax * Grossay);
//            Console.WriteLine($"Your Salary is {NetSalary}");
//        }
//        else
//        {
//            Console.WriteLine($"Your Salary is {Grossay}");
//        }
//    }

//    public void ShowEmployeeDetails()
//    {
//        Console.WriteLine($"Employee Name is {Name}");
//        CalculateSalary();   
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee(3316,"Ritik Srivatsav", 40000);
//        emp.ShowEmployeeDetails();
//        Console.ReadLine();
//    }
//}

/* Abstraction through abstract class */

using System.Diagnostics.Contracts;

abstract class Animal
{
    public abstract void MakeSound();
}
class Dog: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Dog dog = new Dog();
//        dog.MakeSound();
//        Developer1 dev1= new Developer1();
//        dev1.Work();
//    }

//}


//class Employee1
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("Employee is working");
//    }

//}
//class Developer1 : Employee1
//{
//    public override void Work()
//    {
//        Console.WriteLine("Developer is working");
//    }
//}



