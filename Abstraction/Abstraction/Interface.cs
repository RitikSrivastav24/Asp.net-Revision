interface IPhoneCharger
{
    void TypeC();
}

class Samsung : IPhoneCharger
{
    public void TypeC()
    {
        Console.WriteLine("This is samsung charger Type-c");
    }
}

class Oneplus : IPhoneCharger
{
    public void TypeC()
    {
        Console.WriteLine("This is the onelus charger Type-c");
    }
}

//class Program
//{
//    static void Main()
//    {
//        IPhoneCharger charger1 = new Oneplus();
//        IPhoneCharger charger2 = new Samsung();
//        charger1.TypeC();
//        charger2.TypeC();
//    }
//}


/* When to use abstract class : use abstract class for shared base behaviour.   
abstract class Employee
{
    public int EmpId { get; }
    public string EmpName { get; }

    protected Employee(int id, string name)
    {
        EmpId = id;
        EmpName = name;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{EmpId} {EmpName}");
    }
    public abstract void PerformDuties();
}

class Developer : Employee
{
    public Developer(int id, string name) : base(id, name)
    {

    }
    public override void PerformDuties()
    {
        Console.WriteLine("Developing software");
    }
}

class program
{
    static void Main()
    {
        Employee employee = new Developer(3316, "Ritik");
        employee.ShowDetails();
        employee.PerformDuties();

    }
}

Why use an abstract class here?
- EmpId and Name are shared state.
- The constructor initializes that state.
- ShowDetails() is shared implementation.
- PerformDuties() must be implemented by each concrete employee type.
An abstract class lets us combine shared data, shared behavior, and required behavior in one base type. */


/* Multiple Interfaces 
interface IWorkable
{
    void work();
}

interface IReportable
{
    void report();
}
interface IActivities
{
    void activities();
}
class Developer: IWorkable , IReportable, IActivities
{
    public void work()
    {
        Console.WriteLine("Developer is working");
    }
    public void report()
    {
        Console.WriteLine("Developer is reporting");
    }
    public void activities()
    {
        Console.WriteLine("Developer Activities");
    }
}

class Program
{
    static void Main()
    {
        Developer dev= new Developer();
        dev.work();
        dev.report();
        dev.activities();
    }
}

*/

/* Explicit Interface Implementation
interface IDeveloper
{
    void ShowRole();
}

interface IManager
{
    void ShowRole();
}

class Employee : IDeveloper, IManager
{
    void IDeveloper.ShowRole()
    {
        Console.WriteLine("Developer");
    }

    void IManager.ShowRole()
    {
        Console.WriteLine("Manager");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        ((IDeveloper)emp).ShowRole();
        ((IManager)emp).ShowRole();
    }
}
Why can't we call emp.ShowRole() directly? Because explicitly implemented interface members aren't exposed as ordinary public members of the class. We access each implementation through its interface.
Interview tip
Explicit interface implementation is useful when:
-Two interfaces have members with the same name.
- You want a member available only through its interface.
-You want to avoid exposing every interface member as part of the class's normal public API.

    */

