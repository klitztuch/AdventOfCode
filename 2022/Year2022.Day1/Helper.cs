namespace Year2022.Day1;

public static class Helper
{
    public static string[] File2StringArray(string filename)
    {
        return File.ReadAllLines(filename);
    }
}