using System;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Clear();

        // Add Ghosts
        Ghost redGhost = new Ghost(10, 10, ConsoleColor.Red);
        redGhost.Plot();

        Ghost greenGhost = new Ghost(20, 10, ConsoleColor.Green);
        greenGhost.Plot();

        Ghost yellowGhost = new Ghost(30, 10, ConsoleColor.Yellow);
        yellowGhost.Plot();

        Ghost blueGhost = new Ghost(40, 10, ConsoleColor.Blue);
        blueGhost.Plot();


        Console.CursorVisible = true;
        Console.ReadLine();

    }
}
