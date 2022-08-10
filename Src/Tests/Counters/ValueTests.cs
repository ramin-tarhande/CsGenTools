using NUnit.Framework;
using CsGenTools;
using CsGenTools.Counters;

namespace Tests.Counters
{
    public class ValueTests
    {
        [Test]
        public void InsideRange()
        {
            var sut = Counter.CreateWrapping(10);

            sut.Add(7);
            sut.Add(2);

            Assert.AreEqual(9, sut.Value);
        }

        [Test]
        public void ExceedMax()
        {
            var sut = Counter.CreateWrapping(10);

            sut.Add(7);
            sut.Add(5);

            Assert.AreEqual(2, sut.Value);
        }

        [Test]
        public void OnMax()
        {
            var sut = Counter.CreateWrapping(10);

            sut.Add(7);
            sut.Add(3);

            Assert.AreEqual(0, sut.Value);
        }

        [Test]
        public void Wrapping_Large()
        {
            var sut = Counter.CreateWrapping(10);

            sut.Add(903);

            Assert.AreEqual(3, sut.Value);
        }

        [Test]
        public void Simple_Large()
        {
            var sut = Counter.CreateSimple();

            sut.Add(903);

            Assert.AreEqual(903, sut.Value);
        }

    }
}
