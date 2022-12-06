public class SupplyStacks
{
    public static string file_name = "../../../Day-5/Input.txt";
    public static string Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);

        int height = GetHeight(input_lines);
        
        List<Stack<char>> stacks = GetStacks(input_lines, height);

        int selection = 0;
        int origin = 0;
        int destination = 0;
        string[] words = new string[6];

        char current;

        for (int i = height + 2; i < input_lines.Length; i++)
        {
            words = input_lines[i].Split(' ');
            selection = Int32.Parse(words[1]);
            origin = Int32.Parse(words[3]) - 1;
            destination = Int32.Parse(words[5]) - 1;

            for (int j = 0; j < selection; j++)
            {
                current = stacks[origin].Pop();
                stacks[destination].Push(current);
            }
        }

        string return_str = "";

        foreach(Stack<char> stack in stacks)
        {
            return_str = return_str += stack.Peek();
        }

        return return_str;
    }

    private static List<Stack<char>> GetStacks(string[] input, int height)
    {
        List<Stack<char>> stacks = new List<Stack<char>>();

        int length = (input[height].Length / 4);

        for (int i = 0; i <= length; i++)
        {
            stacks.Add(new Stack<char>());
            for (int j = height - 1; j >= 0; j--)
            {
                if (input[j][i * 4 + 1] != ' ')
                {
                    stacks[i].Push(input[j][i * 4 + 1]);
                }
            }
        }

        return stacks;
    }

    private static int GetHeight(string[] input)
    {
        int height = 0;
        while (!input[height].Contains('1'))
        {
            height++;
        }

        return height;
    }

    public static void Main()
    {
        Console.WriteLine(Part1());
    }
}