
/* Association
class Student
{
    public string Name = "Ritik";
}

class Teacher
{
    public void Teach(Student student)
    {
        Console.WriteLine($"{student.Name} is Learning");
    }
}

class Program
{
    static void Main()
    {
        Student s1= new Student();
        Teacher t1= new Teacher();
        t1.Teach(s1);
    }
}
*/


//************************************************************************************************************************************************************************************************

// Aggregation
class Teacher
{
    public string Name;
    public Teacher(string name)
    {
        Name = name;
    }
}

class Department
{
    public Teacher Teacher;
    public Department(Teacher teacher)
    {
        Teacher = teacher;
    }
}

class Program
{
    static void Main()
    {
        Teacher teach = new Teacher("Alok");
        Department d1 = new Department(teach);
        Console.WriteLine($"{teach.Name}");
       
    }
}