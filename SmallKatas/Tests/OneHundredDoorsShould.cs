using System;
using NUnit.Framework;
using SmallKatas;

namespace Tests
{
    [TestFixture]
    public class OneHundredDoorsShould
    {
        bool[] initialDoors;
        OneHundredDoors oneHundredDoors;

        [SetUp]
        public void BeforeEach()
        {
            oneHundredDoors = new OneHundredDoors();
            initialDoors = new bool[100];
        }

        [Test]
        public void VisitAllDoorsAndToggleTheDoor()
        {
            var result = oneHundredDoors.PassByDoors(initialDoors);
            Assert.Contains(true, result);
        }

        [Test]
        public void VisitEverySecondDoorAndToggleIt()
        {
            oneHundredDoors.PassByDoors(initialDoors);
            oneHundredDoors.PassByDoors(initialDoors);

            Assert.IsTrue(initialDoors[0]);
            Assert.IsFalse(initialDoors[1]);
        }

        [Test]
        public void VisitOneHundredTimesInitialDoorsAndToggleThen()
        {
            for (int index = 0; index < initialDoors.Length; index++)
            {
                oneHundredDoors.PassByDoors(initialDoors);
            }

            Assert.IsTrue(initialDoors[0]);
            Assert.IsFalse(initialDoors[49]);
            Assert.IsTrue(initialDoors[99]);
        }
    }
}
 