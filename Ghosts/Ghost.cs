using System;
using System.Collections.Generic;

public class Ghost
{
    // ▄ ▀ █

    // Fields
    private int _x, _y;
    private ConsoleColor _color;
    private Dictionary<int, string[]> _shapes;
    private int _frame;
    private int _timer;
    private int _animationSpeed;

    private string[] _shape = new string[3]
    {
            "▄███▄",
            "█@█@█",
            "█▀█▀█"
    };

    private string[] _shape2 = new string[3]
    {
            "▄███▄",
            "█@█@█",
            "▀█▀█▀"
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
        _shapes = new Dictionary<int, string[]>();
        _shapes[0] = _shape;
        _shapes[1] = _shape2;
        _frame = 0;
        _timer = 0;
        _animationSpeed = 5;
    }

    public void Plot()
    {
        _timer++;
        if (_timer == _animationSpeed)
        {
            _timer = 0;
            _frame++;
            if (_frame == 2) _frame = 0;
        }
        Console.ForegroundColor = _color;
        for (int i = 0; i < _shape.Length; i++)
        {
            Console.SetCursorPosition(_x, _y + i);
            Console.WriteLine(_shapes[_frame][i]);
        }
        Console.ResetColor();
    }

    public void UnPlot()
    {
        for (int i = 0; i < _shape.Length; i++)
        {
            Console.SetCursorPosition(_x, _y + i);
            Console.WriteLine("     ");
        }
    }
}
