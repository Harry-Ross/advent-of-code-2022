using System.Runtime.CompilerServices;

public class RucksackReorganisation
{
    public static string file_name = "../../../Day-3/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        int midpoint = 0;
        string[] compartments = new string[2];
        char common_elements;

        int total = 0;

        foreach(string line in input_lines)
        {
            midpoint = line.Length / 2;
            compartments[0] = line.Substring(0, midpoint);
            compartments[1] = line.Substring(midpoint, midpoint);

            common_elements = GetCommonChar(compartments);

            total += ConvertToPriority(common_elements);
        }
        return total;
    }

    private static int ConvertToPriority(char input)
    {
        if (input >= 'A' && input <= 'Z')
        {
            return input - 'A' + 27;
        }
        else if (input >= 'a' && input <= 'z')
        {
            return input - 'a' + 1;
        }

        return 0;
    } 

    private static char GetCommonChar(string[] input)
    {
        foreach(char first in input[0]) { 
            foreach (char second in input[1])
            {
                if (input.Length == 2 && first == second)
                {
                    return first;
                }
                if (input.Length == 3)
                {
                    foreach(char third in input[2])
                    {
                        if (first == second && second == third)
                        {
                            return first;
                        }
                    }
                }
            }
        }
        
        return '\n';
    }

    public static int Part2()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        string[] current_lines = new string[3];

        int total = 0;

        for (int i = 0; i < input_lines.Length; i += 3)
        {
            current_lines[0] = input_lines[i];
            current_lines[1] = input_lines[i + 1];
            current_lines[2] = input_lines[i + 2];
            total += ConvertToPriority(GetCommonChar(current_lines));
        }
        return total;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Part2());
    }
}