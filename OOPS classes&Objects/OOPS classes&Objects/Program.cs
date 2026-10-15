using System;


class Student // Here we are creating a class named Student
{
    public string Name;
    public int Age;
}


//class Program
//{
//    static void Main()
//    {
//        Student student= new Student();
//        student.Name = "Ritik";
//        student.Age = 20;
//        Student student1 = new Student();
//        student1.Name = "Nitin";

//        Console.WriteLine("Student Name: " + student.Name);
//        Console.WriteLine("Student Age: " + student.Age);
//        Console.WriteLine
//            ("Student Name: " + student1.Name); 
//    }
//}


class Employee
{
    public string Name;  // Here name and salary are fields which represent the data of the Employee object.
    public int Salary;
}

//class Program1
//{
//    static void Main()
//    {
//        Employee employee= new Employee();
//        employee.Name = "Ritik";  // When we write then values are assigned to the fields of the Employee object.
//        employee.Salary = 50000;

//        Console.WriteLine("Employee Name: " + employee.Name);
//        Console.WriteLine("Employee Salary: " + employee.Salary);
//    }
//}

// Parametrized Constructor

class Employee1
{
    public string Name;
    public int Salary;

    public Employee1(string name , int salary) // This is a constructor which is used to initialize the fields of the Employee object.
    {
        Name = name;
        Salary = salary;
    }
}


//class Program2
//{
//    static void Main()
//    {
//        Employee1 employee1 = new Employee1("Ritik",25000);
//        Employee1 employee2 = new Employee1("Nitin", 30000);

//        Console.WriteLine(employee1.Name + " " + employee1.Salary);
//        Console.WriteLine(employee2.Name + " " + employee2.Salary);

//    }
//}


class Book
{
    public string Title;

    public Book(string title) 
    {
        Title = title; 
    }
}

class Program3
{
    static void Main()
    {
        Book book = new Book("C# Basics");
        Console.WriteLine("Book Title: " + book.Title);
    }
}