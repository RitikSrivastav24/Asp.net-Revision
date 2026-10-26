/* Composition represents a has-a relationship
class Processor
{
    public void Start()
    {
        Console.WriteLine("Processor started");
    }
}

class Computer
{
    private readonly Processor _processor= new Processor();
    public void Start()
    {
        _processor.Start();
        Console.WriteLine("Computer Started");
    }
}

class Program
{
    static void Main()
    {
        Computer cmp = new Computer();
        cmp.Start();
    }
}

Here, Computer uses a Processor rather than inheriting from it. This lets us build complex objects by combining smaller components.
Composition is a design relationship, not a special C# keyword. */

/* In the previous example, Computer creates its own Processor. That tightly couples the two classes.
We can improve it by injecting a dependency through an interface: 

using System.Runtime.CompilerServices;

interface IProcessor
{
    void Start();
}

class IntelProcessor : IProcessor
{
    public void Start()
    {
        Console.WriteLine("Intel processor started");
    }
}

class Computer
{
    private readonly IProcessor _processor;

    public Computer(IProcessor processor)
    {
        _processor = processor;
    }

    public void Start()
    {
        _processor.Start();
        Console.WriteLine("Computer started");
    }
}

class Program
{
    static void Main()
    {
        Processor processor = new IntelProcessor();
        Computer computer = new Computer(processor);       
        computer.Start();
    }
}

The benefit is that you can later supply another IProcessor implementation without rewriting Computer.

This connects three concepts you've learned:
- Interface: defines the processor contract.
- Composition: a computer uses a processor.
- Dependency injection: the processor is supplied through the constructor */