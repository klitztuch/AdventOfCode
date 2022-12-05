namespace Year2022.Day3;

public static class Helper
{
    public static string[] File2StringArray(string inputfile)
    {
        return File.ReadAllLines(inputfile);
    }
}
