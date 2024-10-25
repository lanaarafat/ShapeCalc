using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IShape trapezium = new Trapezium();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();
        ((Trapezium)trapezium).CalculateUnkownSides();

        IShape circle = new Circle();
        circle.CalculateArea();
        circle.CalculatePerimeter();
        ((Circle)circle).CalculateRadius();

        IShape nonagon = new Nonagon();
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        ((Nonagon)nonagon).CalculateNumberOfSides();
    }
}

public interface IShape
{
   void CalculateArea();
   void CalculatePerimeter();
}

public class Trapezium : IShape
{
    // Trapezium is an Isosceles trapezium
    public void CalculateUnknownSides()
    {
        float base1 = 5f; //shorter base
        float base2 = 10f; // longer base
        float height = 4f;
        float basediff = (base2 - base1) / 2f;
        float side = MathSqrt ((basediff * basediff) + (height * height));
        Debug.Log("Length of unkown sides" + side);

    }

    public void CalculateArea()
    {
        float base1 = 5f;
        float base2 = 10f;
        float height = 4f;
        float area = 0.5f * (base1 + base2) * height;
        Debug.Log("Trapezium Area: " + area);

    }

    public void CalculatePerimeter()
    {
        float side1 = 5f;
        float side2 = 10f;
        float side3 = 4.72f;
        float side4 = 4.72f;
        float perimeter = side1 + side2 + side3 + side4;
        Debug.Log("Trapezium Perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    public void CalculateArea()
    {
        float radius = 4f;
        float pie = Mathf.PI;
        float area = pie * radius * radius;
        Debug.Log("Circle Area: " + area);
    }

    public void CalculateRadius()
    {
        float diameter = 8f;
        float radius = diameter / 2;
        Debug.Log("Circle Radius: " + radius);
    }

    public void CalculatePerimeter()
    {
        float radius = 4f;
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle Perimeter: " + perimeter);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;

    public void CalculateArea()
    {
        float side1 = 5f;
        float angle = 180f / 9f;
        float cotangent = 1f / (Mathf.Tan(Mathf.Deg2Rad * angle)); // Mathf.Deg2Rad converts degrees to radians since Unity’s trigonometric functions expect angles in radians.
        float area = (9f / 4f) * side1 * side1 * cotangent;
        Debug.Log("Nonagon Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float side1 = 5f;
        float perimeter = 9 * side1;
        Debug.Log("Nonagon Perimeter: " + perimeter);
        
    }

    public int CalculateNumberOfSides()
    {
        Debug.Log("Number of sides in Nonagon: " + numberOfSides)
        return numberOfSides;
    }
}
