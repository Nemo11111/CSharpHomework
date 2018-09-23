using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{

    public abstract class Shape
    {
        private string id;
        public Shape(string s)
        {
            Id = s;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public abstract double Area
        {
            get;
        }
    }

    //正方形类
    public class Square:Shape
    {
        private double squareSide;
            public Square(double side, string id) : base(id)
        {
            squareSide = side;
        }
        public override double Area
        {
            get { return squareSide * squareSide; }
        }
    }

    //圆形类
    public class Circle :Shape
    {
        private double circleRadius;
        public Circle(double radius, string id) : base(id)
        {
            circleRadius = radius;
        }
        public override double Area
        {
            get { return circleRadius * circleRadius * System.Math.PI; }
        }
    }

    //矩形类
    public class Rectangle:Shape
    {
        private double rectangleWidth;
        private double rectangleHeight;
        public Rectangle(double width,double height,string id):base(id)
        {
            rectangleWidth = width;
            rectangleHeight = height;
        }
        public override double Area
        {
            get { return rectangleHeight * rectangleWidth; }
        }
    }

    //三角形类
    public class Triangle :Shape
    {
        private double P;
        private double triangleSide1;
        private double triangleSide2;
        private double triangleSide3;
        public Triangle(double side1,double side2,double side3,string id):base(id)
        {
            triangleSide1 = side1;
            triangleSide2 = side2;
            triangleSide3 = side3;
            P = (side1 + side2 + side3) * 0.5;
        }
        public  override double Area
        {
            get { return System.Math.Sqrt(P * (P - triangleSide1) * (P - triangleSide2) * (P - triangleSide3)); }
        }
    }

    //public class createShape
    //{
    //     protected createShape MyShape (double side1,double side2, double side3,string name)
    //    {
    //        createShape myShape = null;
    //        if(name.Equals("Square"))
    //        {
    //            myShape = new Square(side1,name);
    //        }else if (name.Equals("Circle"))
    //        {
    //            myShape = new Circle(side1, name);
    //        }else if (name.Equals("Rectangle"))
    //       {
    //        myShape = new Rectangle(side1, side2, name);
    //       }else if (name.Equals("Triangle"))
    //       {
    //        myShape = new Triangle(side1, side2, side3, name);
    //       }
    //        return myShape;
    //    }
    //}

    class Program 
    {
        static void Main(string[] args)
        {
            Shape[] shape =
            {
                new Square(5.5,"mySquare"),
                new Circle(5.5,"myCircle"),
                new Rectangle(9.9,5.5,"myRectangle"),
                new Triangle(5.5,5.5,5.5,"myTriangle")
            };
            foreach(Shape s in shape)
            {
                Console.WriteLine(s.Id + " Area = " + s.Area);
            }
        }
    }
}

