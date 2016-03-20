using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Alarm
{
    [TestClass]
    public class UnitTest1
    {
        public enum DaysOfWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        private struct Alarm
        {
            public DaysOfWeek day;
            public int hour;

            public Alarm(DaysOfWeek day, int hour)
            {
                this.day = day;
                this.hour = hour;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}