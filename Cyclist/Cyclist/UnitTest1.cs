using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cyclist
{
    [TestClass]
    public class UnitTest1
    {
        public struct Cyclist
        {
            public string name;
            public int[] records;
            public int diameter;

            public Cyclist(string name, int[] records, int diameter)
            {
                this.name = name;
                this.records = records;
                this.diameter = diameter;
            }
        }

        [TestMethod]
        public void CalculateTotalDistanceTraveled()
        {
            var cyclist = new Cyclist[] { new Cyclist("Fritz", new int[] { 1, 2, 3 }, 3), new Cyclist("Rambo", new int[] { 1, 2, 8 }, 3), new Cyclist("Stalone", new int[] { 2, 3, 6 }, 3) };

            Assert.AreEqual(263, GetTotalDistanceTraveledByAllCyclists(cyclist));
        }

        private double GetTotalDistanceTraveledByAllCyclists(Cyclist[] cyclists)
        {
            double result = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                result += GetTotalDistanceTraveledByOneCyclist(cyclists[i]);
            }
            return (int)result;
        }

        private static double GetTotalDistanceTraveledByOneCyclist(Cyclist cyclists)
        {
            int sum = 0;
            sum = GetNumberOfRotations(cyclists);
            return Math.PI * sum * cyclists.diameter;
        }

        [TestMethod]
        public void CalculateNORotations()
        {
            var cyclist = new Cyclist("Iulian", new int[] { 1, 2, 5 }, 3);

            Assert.AreEqual(8, GetNumberOfRotations(cyclist));
        }

        private static int GetNumberOfRotations(Cyclist cyclists)
        {
            int sum = 0;
            for (int i = 0; i < cyclists.records.Length; i++)
            {
                sum += cyclists.records[i];
            }
            return sum;
        }

        [TestMethod]
        public void MaxSpeedSecond()
        {
            var cyclist1 = new Cyclist("Gabi", new int[] { 3, 2, 1 }, 3);
            Assert.AreEqual(1, GetSecondOfTheMaxSpeed(cyclist1));
            var cyclist2 = new Cyclist("Gabi", new int[] { 1, 2, 3 }, 3);
            Assert.AreEqual(3, GetSecondOfTheMaxSpeed(cyclist2));
        }

        private static int GetSecondOfTheMaxSpeed(Cyclist cyclist)
        {
            int contor = 0;
            int second = 0;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                if (contor < cyclist.records[i])
                {
                    contor = cyclist.records[i];
                    second = i + 1;
                }
            }
            return second;
        }
    }
}