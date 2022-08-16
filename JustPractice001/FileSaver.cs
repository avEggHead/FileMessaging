// See https://aka.ms/new-console-template for more information
internal class FileSaver
{
    internal const string FilePath = "C:\\JustForTesting\\";
    internal const string Suffix = ".txt";
    internal static void Save(MyNewObject item)
    {
        if (!Directory.Exists(FilePath))
        {
            Directory.CreateDirectory(FilePath);
        }

        File.WriteAllText(FilePath + item.Name + Suffix, item.Name.ToString() + " " + item.Description.ToString());

    }
}