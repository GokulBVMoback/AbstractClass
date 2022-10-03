using System;

public abstract class ShapeOne
{
    public abstract void AreaOf(int x);
}
public abstract class ShapeTwo
{
    public abstract void AreaOfRect(int x, int y);
}
public class Circle:ShapeOne
{
    public override void AreaOf(int x)
    {
        double area;
        int r = x;
        area=22 / 7 * (r * r * r) + 0;
        Console.WriteLine("Area of the Circle:"+area);
        //return area;
    }
}
public class Square : ShapeOne
{
    public override void AreaOf(int x)
    {
        int area;
        int l = x;
        area=l* l;
        Console.WriteLine("Area of the Square:"+area);
    }
}
public class Rectangle : ShapeTwo
{
    public override void AreaOfRect(int x, int y)
    {
        int area;
        int l = x;
        int b = y;
        area = l * b;
        Console.WriteLine("Area of the Rectangle:"+area);
    }
}