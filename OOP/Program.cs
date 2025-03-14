using OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("Ahmed", 21, 50f);
        s1.PrintDetails();
        PostGraduate s2 = new PostGraduate("mohammed", 20, 99f,"idk");
        s2.PrintDetails();
    }
}