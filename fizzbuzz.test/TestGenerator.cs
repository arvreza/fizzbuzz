using fizzbuzz;
using NUnit.Framework;

namespace fizzbuzz.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGeneratorCount()
        {
            var generator = new Generator();
            var list = generator.Generate();

            Assert.AreEqual(100, list.Count);
        }

        [Test]
        public void TestGeneratorFizz() {
            var generator = new Generator();
            var list = generator.Generate();

            Assert.AreEqual("2", list[2]);
            Assert.AreEqual("22", list[22]);
            Assert.AreEqual("Fizz", list[3]);
            Assert.AreEqual("Fizz", list[18]);
            Assert.AreEqual("Fizz", list[99]);
        }
        [Test]
        public void TestGeneratorBuzz() {
            var generator = new Generator();
            var list = generator.Generate();

            Assert.AreEqual("Buzz", list[5]);
            Assert.AreEqual("Buzz", list[10]);
            Assert.AreEqual("Buzz", list[20]);
        }

        [Test]
        public void TestGeneratorFizzBuzz() {
            var generator = new Generator();
            var list = generator.Generate();

            Assert.AreEqual("FizzBuzz", list[15]);
            Assert.AreEqual("FizzBuzz", list[30]);
            Assert.AreEqual("FizzBuzz", list[60]);
            Assert.AreEqual("FizzBuzz", list[90]);
        }
    }
}