using System;
using System.Collections.Generic;

public interface IGraphic
{
    void Draw();
}

public class Line : IGraphic
{
    public void Draw()
    {
        Console.WriteLine("Drawing a line");
    }
}

public class CompositeGraphic : IGraphic
{
    private List<IGraphic> _graphics = new List<IGraphic>();

    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public void Draw()
    {
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
    }
}

public class CompositeEx
{
    public static void Run()
    {
        Line line1 = new Line();
        Line line2 = new Line();
        CompositeGraphic graphic = new CompositeGraphic();
        graphic.Add(line1);
        graphic.Add(line2);
        graphic.Draw(); 
    }
}