// Without encapsulation, the internal state of an object can be accessed and modified directly, which can lead to unintended side effects and make it difficult to maintain the code. Encapsulation helps to protect the internal state of an object by providing controlled access through public methods or properties.

//class BankAccount
//{
//    public double balance = 1000;

//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account= new BankAccount();

//        account.balance = -5000;
//        Console.WriteLine(account.balance);  // So this is the problem by creating a balance public anyone can insert inavlid data 
//    }
//}

// with encapsulation

//class BankAccount
//{
//    private double balance = 1000; // cannot change balance from outside

//    public void Deposit(double amount)  // deposit validates amount
//    {
//        if (amount > 0)
//        {
//            balance += amount;
//        }

//    }

//    public double GetBalance() // It reads balance
//    {
//        return balance;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();
//        account.Deposit(100);
//        //account.balance = -5000;  It gives compile time erroe becuase balance is private
//        Console.WriteLine(account.GetBalance());
//    }
//}

//In Previous we getbalance() method but in c# we can use properties also;

//class Employee
//{
//    private double empSalary;

//    public double Salary
//    {
//        get // It executes while reading the property value
//        {
//            return empSalary;
//        }
//        set // It executes while assigning the value to the property
//        {
//            if(value > 0) // The value inside the set which is assigned
//            {
//                empSalary = value;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp= new Employee();

//        emp.Salary = 50000;
//        emp.Salary = -2000;
//        Console.WriteLine(emp.Salary);
//    }
//}


// Private set


using System.Diagnostics.CodeAnalysis;

//class Employee
//{
//    public double Salary { get; private set; }
//    public Employee(double salary)
//    {
//        Salary = salary;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee(50000);
//        emp.Salary = 8000;
//        Console.WriteLine(emp.Salary);
//    }
//}


class Employee
{
    public double empsalary { get; }
    public double employeeId { get; }

    public Employee(double salary, double employeeId)
    {
        empsalary = salary;
        this.employeeId = employeeId;

        //return empsalary;

    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee(5000, 3316);
        Console.WriteLine(employee.empsalary);
        Console.WriteLine(employee.employeeId);
        
    }
}
