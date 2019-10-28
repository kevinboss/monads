using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace sample
{
    public class Enumerable
    {
        [Test]
        public void Example()
        {
            IEnumerable<int> Add1(int value) => new List<int> {value + 1};
            IEnumerable<int> MultiplyBy2(int value) => new List<int> {value * 2};

            IEnumerable<int> monade = new List<int> {3};
            IEnumerable<int> resultMonade = monade.SelectMany(Add1).SelectMany(MultiplyBy2);

            Assert.AreEqual(8, resultMonade.First());
        }
    }
}