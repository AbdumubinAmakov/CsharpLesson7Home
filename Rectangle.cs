using System;

public class Rectangle
{
    // Майдонҳои махфӣ (Private fields)
    private int width;
    private int height;
    private string color;

    // Хусусиятҳо (Public Properties)
    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Конструктор
    public Rectangle(int width, int height, string color)
    {
        this.width = width;
        this.height = height;
        this.color = color;
    }

    // Методҳо (Public Methods)
    public int GetArea()
    {
        return width * height;
    }

    public int GetPerimeter()
    {
        return 2 * (width + height);
    }
}

