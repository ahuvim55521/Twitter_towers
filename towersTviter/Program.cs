using System;
using System.Collections.Generic;
using System.Text;


namespace towersTviter
{
    class Program
    {
        //היקף משולש
        static double PerimeterTriangle(int length, int height)
        {
            double c = Math.Sqrt(length * length + height * height);
            return length + c * 2;
        }


        //הדפסת משולש
        static void PrintTriangle(int length, int height)
        {
            for (int i = 0; i < length / 2; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine('*');

            int numline = 2;
            int sizeLine = length - 2;  //אורך השורה הנוכחית
            int caunt = length / 2 - 1; // כמות סוגי השורות באמצע המגדל
            int aa = (height - 2) / caunt; //כמות השורות לכל מידה
            int cauntAmpty = 1;     //כמות הרווחים לפני השורה

            LineOne(numline, sizeLine, aa, cauntAmpty, height);

            for (int i = 0; i < length; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        static void LineOne(int numline, int sizeLine, int aa, int cauntAmpty, int height)
        {
            if (numline < height)
            {
                if (sizeLine > 3 && (numline - 1) % aa == 0)
                    LineOne(numline + 1, sizeLine - 2, aa, cauntAmpty+1, height);
                else
                    LineOne(numline + 1, sizeLine, aa, cauntAmpty, height);
                for (int i = 0; i < (cauntAmpty + sizeLine); i++)
                {
                    if (i < cauntAmpty)
                        Console.Write(' ');
                    else
                        Console.Write('*');
                    
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {

            int select, length, height;

            Console.WriteLine("To select a rectangle tower press 1");
            Console.WriteLine("To select a triangle tower tap 2");
            Console.WriteLine("Press 0 to finish");
            select = int.Parse(Console.ReadLine());

            while (select != 0)
            {
      

                if (select == 1)
                {
                    Console.WriteLine("Enter the width and height of the tower");
                    length = int.Parse(Console.ReadLine());
                    height = int.Parse(Console.ReadLine());

                    if (Math.Abs(height - length) > 5)
                        Console.WriteLine("The area of the rectangular tower is " + length * height);
                    else
                        Console.WriteLine("The perimeter of a rectangular tower is " +( length * 2 + height * 2));
                }
                if (select == 2)
                {
                    Console.WriteLine("Enter the width and height of the tower");
                    length = int.Parse(Console.ReadLine());
                    height = int.Parse(Console.ReadLine());

                    Console.WriteLine("To calculate the perimeter of a triangular tower, press 10");
                    Console.WriteLine("To print a triangular tower press 20");
                    Console.WriteLine("To enter data for the next tower, press 111");
                    Console.WriteLine("Press 0 to finish");
                    select = int.Parse(Console.ReadLine());
                    while (select != 111 && select !=0)
                    {
                        if (select == 10)
                            Console.WriteLine("The perimeter of a triangular tower is " + PerimeterTriangle(length, height));
                        if (select == 20)
                        {
                            if (length % 2 == 0 || length > height * 2)
                                Console.WriteLine("It is not possible to print the tower");
                            else
                                PrintTriangle(length, height);
                        }


                        Console.WriteLine("To calculate the perimeter of a triangular tower, press 10");
                        Console.WriteLine("To print a triangular tower press 20");
                        Console.WriteLine("To enter data for the next tower, press 111");
                        Console.WriteLine("Press 0 to finish");
                        select = int.Parse(Console.ReadLine());
                    }
                }


                if (select != 0)
                {
                    Console.WriteLine("To select a rectangle tower press 1");
                    Console.WriteLine("To select a triangle tower tap 2");
                    Console.WriteLine("Press 0 to finish");
                    select = int.Parse(Console.ReadLine());
                }
            }


        }
    }
}

