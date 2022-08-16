// See https://aka.ms/new-console-template for more information
internal class MyNewObject
{
    public MyNewObject()
    {
        this.Description = this.GenerateRandomWords();
    }

    private string? GenerateRandomWords()
    {
        return Yakaas.Words.RandomWords.GetSomeRandomText();
    }

    public string Name { get; set; }
    public string Description { get; set; }

    internal void Greet()
    {
        Console.WriteLine("Hi my name is " + this.Name);
        Console.WriteLine("and I like " + this.Description);
    }
}