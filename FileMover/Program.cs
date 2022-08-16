// See https://aka.ms/new-console-template for more information
using FileMover;

Console.CursorVisible = false;
int counter = 0;
do
{
    Console.SetCursorPosition(0,0);
    Console.WriteLine("Looking      " + counter);
    counter++;
    Thread.Sleep(1000);
} while (!FileArchiver.IsThereAFile());

Console.WriteLine("My work is finished");