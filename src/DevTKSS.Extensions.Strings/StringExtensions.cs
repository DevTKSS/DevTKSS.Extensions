namespace DevTKSS.Extensions.Strings;
public static class StringExtensions
{
    /// <summary>
    /// Replaces decimal separator from comma to dot.
    /// </summary>
    public static string ReplaceDecSep(this string value)
    {
        return value.Replace(',', '.');
    }

    /// <summary>
    /// Replaces decimal separator from dot to comma.
    /// </summary>
    public static string ReplaceSepDec(this string value)
    {
        return value.Replace('.', ',');
    }

    public static string RemovePathExtension(this string path)
    {
        return Path.ChangeExtension(path, null);
    }
    public static string RemoveFileExtension(this string filename)
    {
        return Path.GetFileNameWithoutExtension(filename);
    }

}
