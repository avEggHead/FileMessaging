// See https://aka.ms/new-console-template for more information
using FileMover;

Console.CursorVisible = false;
int counter = 0;

StartLoop:
Console.Clear();
do
{
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Looking      " + counter);
    counter++;
    Thread.Sleep(1000);
} while (!FileArchiver.IsThereAFile());

FileArchiver.MoveTheFiles();
Console.WriteLine("My work is finished");
Console.WriteLine("Continue?");
var input = Console.ReadKey();
if(input.Key == ConsoleKey.Y)
{
    goto StartLoop;
}
Console.WriteLine("All Done");