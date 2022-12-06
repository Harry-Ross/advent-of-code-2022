public class SupplyStacks
{
    public static string file_name = "../../../Day-5/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);

        List<Stack<char>> stacks = GetStacks(input_lines);
        return 0;
    }

    private static List<Stack<char>> GetStacks(string[] input)
    {
        List<Stack<char>> stacks = new List<Stack<char>>();

        int height = 0;
        while (!input[height].Contains('1'))
        {
            height++;
        }

        int length = (input[height].Length / 4);

        for (int i = 0; i < length; i++)
        {
            stacks.Add(new Stack<char>());
            for (int j = height - 1; j > 0; j--)
            {
                stacks[i].Push(input[j][i * 4 + 1]);
            }
        }

        foreach (char x in stacks[0])
        {
            Console.WriteLine("Hello" + x);
        }

        return stacks;
    }

    public static void Main()
    {
        Part1();
    }
}