using Figures;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(40, 16);

            //for (int x = 0; x < 5; x++)
            //{
            //    for (int y = 0; y < 10; y++)
            //    {
            //        var p3 = new Point(x, y, '#');
            //        p3.Draw();
            //    }
            //}
            //List<Point> pList = new List<Point>();

            //pList.Add(new Point(10, 10, 'c'));
            //pList.Add(new Point(11, 10, 'c'));
            //pList.Add(new Point(3, 10, 'c'));
            //pList.Add(new Point(10, 2, 'c'));
            //pList.Add(new Point(7, 10, 'c'));

            //foreach (var p in pList)
            //{
            //    p.Draw();
            //}

            HorizontalLine hLine = new HorizontalLine(0, 0, 36, '#');
            HorizontalLine hLine2 = new HorizontalLine(0, 20, 36, '#');
            hLine.Draw();
            hLine2.Draw();

            VerticalLine vLine = new VerticalLine(0, 0, 21, '#');
            VerticalLine vLine2 = new VerticalLine(36, 0, 21, '#');
            vLine.Draw();
            vLine2.Draw();

            Random rand = new Random();

            Point p = new Point(5, rand.Next(2, 10), '*');
            p.Draw();

            while (true)
            {
                Thread.Sleep(300);
                p.Move(Direction.Down);
            }

            Console.ReadLine();
        }
    }
}
