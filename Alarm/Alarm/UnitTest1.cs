using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Alarm
{
    [TestClass]
    public class UnitTest1
    {
        [Flags]
        public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
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
        public void VerifyAlarms()
        {
            var alarm = new Alarm[]
                {
                 new Alarm(DaysOfWeek.Monday, 8),
            new Alarm(DaysOfWeek.Wednesday, 10),
            new Alarm(DaysOfWeek.Friday,9),
            new Alarm(DaysOfWeek.Thursday,7)
                };

            Assert.IsTrue(GetAlarm(alarm, DaysOfWeek.Monday, 8));
            Assert.IsFalse(GetAlarm(alarm, DaysOfWeek.Friday, 12));
        }

        [TestMethod]
        public void CheckSameAlarmDifferentDaywithFlags()
        {
            var alarm = new Alarm[] {
                new Alarm(DaysOfWeek.Monday| DaysOfWeek.Tuesday|DaysOfWeek.Wednesday|DaysOfWeek.Saturday,10),
                new Alarm(DaysOfWeek.Friday|DaysOfWeek.Thursday,12)
            };

            Assert.IsTrue(GetAlarm(alarm, DaysOfWeek.Monday, 10));
        }

        private bool GetAlarm(Alarm[] alarm, DaysOfWeek day, int hour)
        {
            for (int i = 0; i < alarm.Length; i++)
            {
                if ((alarm[i].day == day && (alarm[i].hour == hour)))
                    return true;
            }
            return false;
        }
    }
}