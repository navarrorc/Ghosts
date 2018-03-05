using System;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Clear();

        // Add Ghosts
        Ghost redGhost = new Ghost(10, 10, ConsoleColor.Red);
        Ghost greenGhost = new Ghost(20, 10, ConsoleColor.Green);
        Ghost yellowGhost = new Ghost(30, 10, ConsoleColor.Yellow);
        Ghost blueGhost = new Ghost(40, 10, ConsoleColor.Blue);

        // Animate the Ghosts
        while (true)
        {
            redGhost.Plot();
            greenGhost.Plot();
            yellowGhost.Plot();
            blueGhost.Plot();

            System.Threading.Thread.Sleep(20);
            redGhost.UnPlot();
            greenGhost.UnPlot();
            yellowGhost.UnPlot();
            blueGhost.UnPlot();
        }


        Console.CursorVisible = true;
        Console.ReadLine();

    }
}
