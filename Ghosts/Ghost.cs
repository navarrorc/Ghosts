using System;

public class Ghost
{
    // ▄ ▀ █

    // Fields
    private int _x, _y;
    private ConsoleColor _color;
    private string[] _shape = new string[3]
    {
            "▄███▄",
            "█@█@█",
            "█▀█▀█"
    };

    // Properties
    // ...


    // Methods
    public Ghost(int x, int y, ConsoleColor color)
    {
        // Constructor
        _x = x;
        _y = y;
        _color = color;
    }

    public void Plot()
    {
        Console.ForegroundColor = _color;
        for (int i = 0; i < _shape.Length; i++)
        {
            Console.SetCursorPosition(_x, _y + i);
            Console.WriteLine(_shape[i]);
        }
        Console.ResetColor();
    }
}
