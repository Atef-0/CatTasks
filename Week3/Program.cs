internal class Program
{

    public static void Swap<T>(ref T x, ref T y)
    {
        var z = x;
        x = y;
        y = z;
    }
    public static void FindStudent(string name,Dictionary<string, int> dic)
    {
        if (dic.ContainsKey(name))
        {
            Console.WriteLine($"Stdent Found!\nStudent name:{name} Student Grade: {dic[name]}");
        }else
            Console.WriteLine("student not found");
    }
    private static void Main(string[] args)
    {
        string s1 = "O.O";
        string s2 = ":l";
        Console.WriteLine($"Values before swapping: s1: {s1}, s2: {s2}");
        Swap(ref s1, ref s2);
        Console.WriteLine($"Values after swapping: s1: {s1}, s2: {s2}");
        int i1 = 17;
        int i2 = 5;
        Console.WriteLine($"Values before swapping: i1: {i1}, i2: {i2}");
        Swap(ref i1, ref i2);
        Console.WriteLine($"Values after swapping: i1: {i1}, i2: {i2}");
        Console.WriteLine("------------------------------------------------");
        Dictionary<string, int> dic = new Dictionary<string, int> { { "h", 12 }, { "d", 45 }, { "g", 87 },  { "k", 65 },{ "x", 88 }, };
        FindStudent("h", dic);
        FindStudent("aaaa", dic);
        Console.WriteLine("------------------------------------------------");
        Queue<string> q = new Queue<string>();
        q.Enqueue("mohammed");
        q.Enqueue("ahmed");
        q.Enqueue("Iyad");
        q.Enqueue("Mori");
        q.Enqueue("Mills");
        q.Enqueue("Zuko");
        Console.WriteLine($"Currently serving: {q.Dequeue()}");
        Console.WriteLine($"Next customer in line: {q.Peek()}");
        Console.WriteLine($"First Customer done\nnow serving: {q.Dequeue()}");
        Console.WriteLine("remaining customers: ");
        foreach (var item in q)
        {
            Console.WriteLine(item);
        }







    }
    
}
//3-Implement a Queue<string> to simulate a customer service line.
//*Add customers to the queue.
//*Process them one by one, displaying their names as they are served.

