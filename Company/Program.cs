using Company;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee emp1 = new Employee(1, "mohammed", SecurityLevel.DBA, 9.50m, new DateTime(2023, 3, 11), Gender.M);
        Employee emp2 = new Employee(2, "Ahmed", SecurityLevel.Guest, 3m, new DateTime(2011, 8, 3), Gender.M);

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);

    }
}