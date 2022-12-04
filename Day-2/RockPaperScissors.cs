using System;
using System.IO;

public class RockPaperScissors
{
    public static string file_name = "../../../Day-2/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        int score = 0;

        int win = 0;

        foreach(string line in input_lines)
        {
            string[] current = line.Split(" ");
            score += current[1][0] - 'W';

            win = WinPoints(current[0][0], current[1][0]);
            score += win;
        }

        return score;
    }

    private static int WinPoints(char p1, char p2)
    {
        if ((p1 == 'A' && p2 == 'Z') || (p1 == 'C' && p2 == 'Y') || (p1 == 'B' && p2 == 'X'))
        {
            return 0;
        }
        if ((p1 - '@') == (p2 - 'W'))
        {
            return 3;
        }

        return 6;
    }
}