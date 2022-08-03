using System;


namespace ShapeOperations
{
    class Operations
    {
        static void Main(string[] args)
        {
            int sideS = 10;
            int length = 5, width = 10;
            ShapeOperations.Square.AreaS(sideS);
            ShapeOperations.Rectangle.AreaR(length,width);
        }
    }

    class Square
    {
        public static void AreaS(int side)
        {
            int areaSquare = side*side;
            Console.WriteLine("Area of square is : "+ areaSquare);
        }
    }
    
    class Rectangle
    {
        public static void AreaR(int length,int width)
        {
            int areaRect = length*width;
            Console.WriteLine("Area of Rectangle is : " + areaRect);
        }
    }
}