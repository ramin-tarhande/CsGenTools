using NUnit.Framework;
using CsGenTools;
using CsGenTools.Counters;

namespace Tests.Counters
{
    class EventTests
    {
        private Counter sut;
        private bool eventFired;
        
        [SetUp]
        public void Init()
        {
            eventFired = false;

            sut = Counter.CreateWrapping(10);

            sut.Wrapped+=()=>eventFired=true;
        }


        [Test]
        public void InsideRange()
        {
            sut.Add(7);
            sut.Add(2);

            Assert.IsFalse(eventFired);
        }

        [Test]
        public void ExceedMax()
        {
            sut.Add(7);
            sut.Add(5);

            Assert.IsTrue(eventFired);
        }
    }
}
