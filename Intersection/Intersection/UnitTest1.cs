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
            Right, Left, Down, Up
        }

        [TestMethod]
        public void VerifyPoint1()
        {
            Route[] direction = new Route[]
           {    Route.Right, Route.Up, Route.Up, Route.Right,Route.Down,Route.Left
           };
            var intersection = new Point(1, 1);

            Assert.AreEqual(intersection, GetIntersectionPoint(direction));
        }

        [TestMethod]
        public void VerifyPoint2()
        {
            Route[] direction = new Route[]
             {
           Route.Up,Route.Up,Route.Right,Route.Down,Route.Down,Route.Left
              };
            var intersection = new Point(0, 0);
            Assert.AreEqual(intersection, GetIntersectionPoint(direction));
        }

        private Point GetIntersectionPoint(Route[] direction)
        {
            Point intersection = new Point(0, 0);
            Point[] points = new Point[direction.Length];

            for (int i = 0; i < direction.Length; i++)
            {
                GetDirections(direction[i], intersection);

                for (int j = 0; j < points.Length; j++)
                {
                    if (CheckForIntersection(points[j], points))
                        return intersection;
                }
            }

            return intersection;
        }

        private bool CheckForIntersection(Point reference, Point[] points)
        {
            for (int j = 0; j < points.Length - 1; j++)
            {
                if ((points[j].abscis == reference.abscis) && (points[j].ordinate == reference.ordinate))
                    return true;
            }
            return false;
        }

        public void GetDirections(Route direction, Point way)
        {
            switch (direction)
            {
                case Route.Right:
                    way = new Point(way.abscis + 1, way.ordinate);
                    break;

                case Route.Left:
                    way = new Point(way.abscis - 1, way.ordinate);
                    break;

                case Route.Down:
                    way = new Point(way.abscis, way.ordinate - 1);
                    break;

                case Route.Up:
                    way = new Point(way.abscis, way.ordinate + 1);
                    break;
            }
        }
    }
}