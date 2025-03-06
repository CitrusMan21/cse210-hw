using System;


class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area; 
    }

    public void DisplayCircleArea()
    {
        Console.WriteLine($"the area of the circle is {GetArea()}");
    }

    public void SetRadius(double r)
     {
        radius = r;
    }
}


class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Hello Today - March 3, 2025");

        // double x = 10;
        Circle myCircle = new Circle(10);

        myCircle.DisplayCircleArea();

         Circle myCircle2 = new Circle(20);

        myCircle2.DisplayCircleArea();

        for(int i= 0; i < 30; i++);
        {
            myCircle.SetRadius(i);
            double circlArea = myCircle.GetArea();
            Console.Writeline($"{i}: Circle area is {Circle Radius}")
        }
    }
}