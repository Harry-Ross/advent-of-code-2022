class CampCleanup
{
    public static string file_name = "../../../Day-4/Input.txt";
    public static int Part1()
    {
        string[] input_lines = File.ReadAllLines(file_name);

        int counter = 0;

        for (int i = 0; i < input_lines.Length; i++)
        {
            string[] current = input_lines[i].Split(",");
            string[] first = current[0].Split('-');
            string[] second = current[1].Split("-");

            

            if (Int32.Parse(first[0]) >= Int32.Parse(second[0]) && Int32.Parse(first[1]) <= Int32.Parse(second[1]))
            {
                counter++;
            }
            else if (Int32.Parse(first[0]) <= Int32.Parse(second[0]) && Int32.Parse(first[1]) >= Int32.Parse(second[1]))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int Part2()
    {
        var sequnce = Enumerable.Range(0, 12);

        string[] input_lines = File.ReadAllLines(file_name);

        int counter = 0;
        bool flag = false;

        for (int i = 0; i < input_lines.Length; i++)
        {
            string[] current = input_lines[i].Split(",");
            string[] first = current[0].Split('-');
            string[] second = current[1].Split("-");


            flag = false;

            for (int x = Int32.Parse(first[0]); x <= Int32.Parse(first[1]); x++)
            {
                for (int y = Int32.Parse(second[0]); y <= Int32.Parse(second[1]); y++)
                {
                    if (y == x)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                counter++;
            }
        }

        return counter;
    }
}