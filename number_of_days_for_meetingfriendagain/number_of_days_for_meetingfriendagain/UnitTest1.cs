using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace number_of_days_for_meetingfriendagain
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, meetingdays(4, 6));

        }

        int meetingdays(int me,int myfriend)
        {
            int product = me * myfriend;

            while (me != myfriend)
            {
                if (me > myfriend)
                    me = me - myfriend;
                else
                    myfriend = myfriend- me;
            }

            return product / me;

        }


    }
}
