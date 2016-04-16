using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Route[] way = new Route[]
            {
                Route.Right,Route.Up,Route.Up,Route.Right,Route.Down,Route.Left
            };
            var intersection = new Point(1, 1);

            Assert.AreEqual(intersection, GetIntersectionPoint(way));
        }

        [TestMethod]
        public void VerifyPoint2()
        {
            Route[] way = new Route[] {
                Route.Up,Route.Up,Route.Right,Route.Down,Route.Down,Route.Left
            };
            var intersection = new Point(0, 0);
            Assert.AreEqual(intersection, GetIntersectionPoint(way));
        }

        private Point GetIntersectionPoint(Route[] direction)
        {
            Point intersection = new Point(0, 0);

            Point[] Point = new Point[direction.Length];

            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == Route.Up) intersection.ordinate += 1;

                if (direction[i] == Route.Down) intersection.ordinate -= 1;

                if (direction[i] == Route.Right) intersection.abscis += 1;

                if (direction[i] == Route.Left) intersection.abscis -= 1;

                for (int j = 0; j < Point.Length; j++)
                {
                    if (Point[j].abscis == intersection.abscis && Point[j].ordinate == intersection.ordinate)
                        return intersection;
                }
                Point[i].abscis = intersection.abscis;

                Point[i].ordinate = intersection.ordinate;
            }
            return intersection;
        }
    }
}