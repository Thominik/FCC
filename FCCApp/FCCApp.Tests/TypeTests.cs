using System.Runtime.CompilerServices;

namespace FCCApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void StringShouldReturnSameValues()
        {
            string name1 = "Dominik";
            string name2 = "Dominik";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void StringShouldReturnDifferentValues()
        {
            string name1 = "Dominik";
            string name2 = "Adam";

            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void IntShouldReturnDifferentValues()
        {
            int number1 = 2;
            int number2 = 3;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void FloatShouldReturnDifferentValues() 
        {
            float number1 = 2.2f;
            float number2 = 2.6f;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void BooleanShouldReturnSameValues()
        {
            bool bool1 = false;
            bool bool2 = false;

            Assert.AreEqual(bool1, bool2);
        }
    }
}
