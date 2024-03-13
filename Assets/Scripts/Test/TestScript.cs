using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Start()
    {
        Circle c1 = new Circle(10f);
        Rectangle r1 = new Rectangle(10f, 10f);

        Debug.Log("circle area: " + c1.Area());
        Debug.Log("rectangle area: " + r1.Area());

        List<Shape> list = new List<Shape>();
        list.Add(c1);
        list.Add(r1);
        GetAllArea(list);
    }

    void GetAllArea(List<Shape> list)
    {
        foreach (Shape shape in list)
        {
            Debug.Log(shape.Area());
        }
    }
}
