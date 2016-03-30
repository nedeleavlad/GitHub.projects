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

        public struct Maximum
        {
            public string name;
            public int second;

            public Maximum(string name, int second)
            {
                this.name = name;
                this.second = second;
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
        public void GetCyclistWithSpeedMaximum()
        {
            var cyclist = new Cyclist[] { new Cyclist("Bobo", new int[] { 1, 2, 3 }, 3), new Cyclist("Florin", new int[] { 1, 2, 4 }, 3), new Cyclist("Andrew", new int[] { 6, 3, 1 }, 3) };

            Assert.AreEqual(new Maximum("Andrew", 1), CyclistMaxSpeed(cyclist));
        }

        private Maximum CyclistMaxSpeed(Cyclist[] cyclist)
        {
            int index = 0;

            Maximum maximum = new Maximum { };

            double result = 0;

            double speed = 0;

            for (int i = 0; i < cyclist.Length; i++
                )
            {
                speed = GetMaximSpeedForOneCyclist(cyclist[i]);

                if (result < speed)
                {
                    int second = 0;

                    result = speed;

                    index = i;

                    second = GetSecondWhitMaximumSpeed(cyclist[index]);

                    maximum = CompleteStructMax(cyclist, index);
                }
            }
            return maximum;
        }

        private static Maximum CompleteStructMax(Cyclist[] cyclist, int index)
        {
            Maximum maximum = new Maximum { };

            int second = 0;

            second += GetSecondWhitMaximumSpeed(cyclist[index]);

            maximum.name = cyclist[index].name;

            maximum.second = GetSecondOfTheMaxSpeed(cyclist[index]);

            return maximum;
        }

        private static int GetSecondWhitMaximumSpeed(Cyclist cyclist)
        {
            int counter = 0;
            int second = 0;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                if (0 < cyclist.records[i])
                {
                    counter = cyclist.records[i];
                    second = i;
                }
            }
            return second + 1;
        }

        private static int GetMaximSpeedForOneCyclist(Cyclist cyclist)
        {
            double distance = 0;

            distance = Math.PI * cyclist.records[GetSecondOfTheMaxSpeed(cyclist) - 1] * cyclist.diameter;

            return (int)(distance);
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

        [TestMethod]
        public void AverageSpeed()
        {
            var cyclist = new Cyclist[] { new Cyclist("Bogdan", new int[] { 1, 2, 3 }, 3), new Cyclist("Vlad", new int[] { 1, 2, 4 }, 3), new Cyclist("Tim", new int[] { 1, 3, 6 }, 3) };
            Assert.AreEqual("Tim", GetAverageSpeed(cyclist));
        }

        private string GetAverageSpeed(Cyclist[] cyclist)
        {
            double result = 0;

            double counter = 0;

            int index = 0;

            for (int i = 0; i < cyclist.Length; i++)
            {
                counter = GetAverageSpeedOneCyclist(cyclist[i]);

                if (result < counter)
                {
                    result = counter;
                    index = i;
                }
            }

            return cyclist[index].name;
        }

        private static double GetAverageSpeedOneCyclist(Cyclist cyclist)
        {
            int second = 0;

            second = cyclist.records.Length;

            return (GetNumberOfRotations(cyclist) / second);
        }
    }
}