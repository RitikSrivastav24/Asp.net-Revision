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

class Program
{
    static void Main()
    {
        IPhoneCharger charger1 = new Oneplus();
        IPhoneCharger charger2 = new Samsung();
        charger1.TypeC();
        charger2.TypeC();
    }
}


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