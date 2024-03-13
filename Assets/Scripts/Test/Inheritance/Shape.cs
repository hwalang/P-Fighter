using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape
{
    public float x, y;
    virtual public float Area()
    {
        return x * y;
    }
}

public class Rectangle : Shape
{
    public float width, height;

    public Rectangle(float w, float h)
    {
        x = w;
        y = h;
        width = w;
        height = h;
    }
}

public class Circle : Shape
{
    public float radius;

    public Circle(float radius)
    {
        x = radius;
        this.radius = radius;
    }

    override public float Area()
    {
        return 3.14f * radius * radius;
    }
}
