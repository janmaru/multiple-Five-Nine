using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MultipleOfFiveAndNine.Tests
{
    public class NaturalNumberTests
    {
        private readonly IEnumerable<int> listOfNumbers;
        private IEnumerable<int> first20NaturalNumbers;
        private IEnumerable<int> first40NaturalNumbers;
        private const int TWENTY = 20;
        private const int FORTY = 40;
        public NaturalNumberTests()
        {
            listOfNumbers = NaturalNumber.LessEqualThen(3000);
        }

        [SetUp]
        public void Setup()
        {
            first20NaturalNumbers = listOfNumbers.OrderBy(x => x).Where(x => x <= TWENTY);
            first40NaturalNumbers = listOfNumbers.OrderBy(x => x).Where(x => x <= FORTY);
        }

        [Test]
        public void NaturalNumber_SumOfFiveORNineMultipliersLessEqualThenTwenty_IsTrue()
        {
            Assert.AreEqual(77, first20NaturalNumbers.SumOfFiveORNineMultipliers());
        }

        [Test]
        public void NaturalNumber_SumOfFiveORNineMultipliersLessEqualThenF0rty_IsTrue()
        {
            Assert.AreEqual(270, first40NaturalNumbers.SumOfFiveORNineMultipliers());
        }
    }
}