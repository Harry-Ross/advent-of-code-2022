using System;
using System.IO;

class Day1CalorieCounter
{
    public static string file_name = "../../../Day-1/Input.txt";
    public static int Part1()
    {
        List<int> calorie_count = GetCalorieCount();

        return calorie_count.Max();
    }

    public static int Part2()
    {
        List<int> calorie_count = GetCalorieCount();

        calorie_count.Sort();
        calorie_count.Reverse();
        return calorie_count.Take(3).Sum();
    }

    private static List<int> GetCalorieCount()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        List<int> calorie_count = new List<int>();
        int current = 0;
        foreach (string line in input_lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                calorie_count.Add(current);
                current = 0;
                continue;
            }

            current += int.Parse(line);

        }

        return calorie_count;
    }
}
