
using System.ComponentModel;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Fill in your Array: ");
        int[] plane = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Console.WriteLine("Your Starting Position: ");
        int ordinalIndex = int.Parse(Console.ReadLine());
        string stopword = "Supernova";
        int damage = 1;
        do
        {
            Console.WriteLine("Your input command: ");
            string[] input = Console.ReadLine().Split(" ").ToArray();

            if (input[0] == stopword)
            {
                break;
            }
            if (input[0] == "left")
            {
                for(int i = 0; i < int.Parse(input[1]); i++)
                { 
                    ordinalIndex--;
                    if (ordinalIndex < 0)
                    {
                        ordinalIndex = plane.Length - 1;
                        damage++;
                    }
                    plane[ordinalIndex] -= damage;
                }   
            }
            if (input[0] == "right")
            {
                for (int i = 0; i < int.Parse(input[1]); i++)
                {
                    ordinalIndex++;
                    if (ordinalIndex > plane.Length -1)
                    {
                        ordinalIndex = 0;
                        damage++;
                    }
                    plane[ordinalIndex] -= damage;
                }

            }
        }
        while (true);

        Console.WriteLine("Current state of the Array: ");
        for (int i = 0; i < plane.Length; i++)
        {
            Console.Write(plane[i] + " ");
        }
    }
}

