namespace Year2022.Day3;

public static class Helper
{
    public static string[] File2StringArray(string inputfile)
    {
        return File.ReadAllLines(inputfile);
    }

    public static int Item2Points(string item)
    {
        // Set start value for ascii conversion
        var value = -96;
        var letter = char.Parse(item);
        if (Char.IsUpper(letter))
        {
            value += 26;
        }
        value += char.ToLower(letter);
        return value;
    }
}
