using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Intersection
{
    [TestClass]
    public class UnitTest1
    {
        public struct Point
        {
            public int abscis;
            public int ordinate;

            public Point(int x, int y)
            {
                this.abscis = x;
                this.ordinate = y;
            }
        }

        public enum Route
        {
            Up, Down, Left, Right
        }

        [TestMethod]
        public void VerifyPoint1()
        {
            // Route[] way = new Route[]
            //{
            //  Route.Right,Route.Up,Route.Up,Route.Right,Route.Down,Route.Left
            //};
            var intersection = new Point(1, 1);

            Assert.AreEqual(intersection, GetIntersectionPoint("RUURDL"));
        }

        [TestMethod]
        public void VerifyPoint2()
        {
            //  Route[] way = new Route[] {
            //    Route.Up,Route.Up,Route.Right,Route.Down,Route.Down,Route.Left
            //};
            var intersection = new Point(0, 0);
            Assert.AreEqual(intersection, GetIntersectionPoint("UURDDL"));
        }

        private Point GetIntersectionPoint(string way)
        {
            Point intersection = new Point(0, 0);

            Point[] points = { intersection };

            Point[] Point = new Point[way.Length - 1];

            foreach (char i in way)
            {
                GetDirections(i, intersection);

                if (CheckForIntersection(intersection, points))
                {
                    return intersection;
                }
            }
            return intersection;
        }

        private bool CheckForIntersection(Point reference, Point[] points)
        {
            for (int j = 0; j < points.Length - 1; j++)
            {
                if (points[j].abscis == reference.abscis && points[j].ordinate == reference.ordinate)
                    return true;
            }
            return false;
        }

        public void GetDirections(char direction, Point way)
        {
            switch (direction)
            {
                case 'R':
                    way = new Point(way.abscis + 1, way.ordinate);
                    break;

                case 'L':
                    way = new Point(way.abscis - 1, way.ordinate);
                    break;

                case 'D':
                    way = new Point(way.abscis, way.ordinate - 1);
                    break;

                case 'U':
                    way = new Point(way.abscis, way.ordinate + 1);
                    break;
            }
        }
    }
}