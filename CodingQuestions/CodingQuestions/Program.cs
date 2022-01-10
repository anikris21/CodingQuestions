// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using CodingQuestions;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("--------------------------");

        Collections collections = new Collections();
        collections.TestList();

        collections.TestDictionary();

        //PermuteString solution = new PermuteString();
        //string str = "ABCD";

        //Console.WriteLine($"Permutations of  {str}");
        //solution.Permute(str, "", str);

        //Console.WriteLine("----------------------------");
        //for (int i = 0; i < 4; i++)
        //{
        //    var s = solution.SwapXor("ABCD", i);
        //    Console.WriteLine(s);
        //}
        Console.ReadKey();

    }
}