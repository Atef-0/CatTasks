internal class Program
{
   // 1-Create a generic method Swap<T> that swaps two variables of any type.
   //    *Test the method with integers and strings.
   //    * Output the results before and after the swap.'

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
 
 
 


    }
    
}