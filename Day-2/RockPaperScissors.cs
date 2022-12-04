using System;
using System.IO;
using System.Xml.Schema;

enum Choices
{
    Rock = 1,
    Paper = 2,
    Scissors = 3
}

public class RockPaperScissors
{
    public static string file_name = "../../../Day-2/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        int score = 0;

        int win = 0;

        foreach (string line in input_lines)
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

    public static int Part2()
    {
        string[] input_lines = File.ReadAllLines(file_name);
        int score = 0;
        string[] current = new string[2];

        foreach (string line in input_lines)
        {
            current = line.Split(" ");

            // lose
            if (current[1][0] == 'X')
            {
                if (current[0][0] == 'A')
                {
                    score += (int)Choices.Scissors;
                }
                else if (current[0][0] == 'B')
                {
                    score += (int)Choices.Rock;
                }
                else if (current[0][0] == 'C')
                {
                    score += (int)Choices.Paper;
                }
            }

            // draw
            else if (current[1][0] == 'Y')
            {
                score += 3;
                score += current[0][0] - '@';
            } 
            
            // win
            else if (current[1][0] == 'Z')
            {
                score += 6;
                if (current[0][0] == 'A')
                {
                    score += (int)Choices.Paper;
                }
                else if (current[0][0] == 'B')
                {
                    score += (int)Choices.Scissors;
                }
                else if (current[0][0] == 'C')
                {
                    score += (int)Choices.Rock;
                }
            }


        }

        return score;
    }
}