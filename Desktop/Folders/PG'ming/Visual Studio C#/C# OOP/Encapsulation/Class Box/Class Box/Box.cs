using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private double length;
    private double width;
    private double height;
    bool passed = true;

    public Box(double length, double width, double heigth)
    {
        this.Length = length;
        this.Width = width;
        this.Height = heigth;
    }
    public double Length {
        get
        {
            return this.length;
        }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
                passed = false;
            }
            this.length = value;
        }
    }
    public double Width {
        get
        {
            return this.width;
        }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
                passed = false;
            }
            this.width = value;
        }
    }
    public double Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
                passed = false;
            }
            this.height = value;
        }
    }

    public double SArea()
    {
        if (passed == true)
        {
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }
        else
        {
            Environment.Exit(0);
            return 2;
        }
    }
    public double LSArea()
    {
        if (passed == true)
        {
            return 2 * Length * Height + 2 * Width * Height;
        }
        else
        {
            Environment.Exit(0);
            return 2;
        }
    }
    public double Volume()
    {
        if (passed == true)
        {
            return Length * Height * Width;
        }
        else
        {
            Environment.Exit(0);
            return 2;
        }
    }
}
