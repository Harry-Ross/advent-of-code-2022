class TuningTrouble
{
    public static string file_name = "../../../Day-6/Input.txt";

    public static int Part1()
    {
        string input_line = File.ReadAllLines(file_name)[0];

        return Finder(input_line, 4);
    }

    public static int Part2()
    {
        string input_line = File.ReadAllLines(file_name)[0];

        return Finder(input_line, 14);
    }

    public static int Finder(string input, int length)
    {
        int position = length;

        while (position < input.Length && !IsUnique(input.Substring(position - length, length)))
        {
            position++;
        }

        return position;
    }

    private static bool IsUnique(string input)
    {
        bool[] letters = new bool[26];
        
        foreach (char letter in input)
        {
            if (letters[letter - 'a'] == true)
            {
                return false;
            } 
            letters[letter - 'a'] = true;
        }
        return true;
    }
}