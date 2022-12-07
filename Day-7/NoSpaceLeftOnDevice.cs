class NoSpaceLeftOnDevice
{
    public static string file_name = "../../../Day-7/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);

        int i = 0;
        bool output = false;

        while (i < input_lines.Length)
        {
            string[] output_line = input_lines[i].Split(' ');
            if (output_line[0] == "$")
            {
                output = false;
                if (output_line[1] == "cd")
                {

                }
                else if (output_line[1] == "ls")
                {
                    output = true;
                }
            }
            else if (output)
            {

            }
            i++;
        }

        return 0;
    }
    public static void Main()
    {

    }
}