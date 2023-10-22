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

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            var user1 = GetUser("Dominik");
            var user2 = GetUser("Dominik");

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void GetUserShouldReturnSameObjects()
        {
            var user1 = GetUser("Dominik");
            var user2 = GetUser("Dominik");

            Assert.AreEqual(user1.Login, user2.Login);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
