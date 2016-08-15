using NUnit.Framework;

namespace RobotWars.UnitTests
{
    [TestFixture]
    public class LocationTests
    {
        [Test]
        public void When_different_objects_are_same_value_then_equality_operator_returns_true()
        {
            Location a = new Location(1, 2);
            Location b = new Location(1, 2);

            Assert.IsTrue(a == b);
        }

        [Test]
        public void When_different_objects_are_different_value_then_equality_operator_returns_false()
        {
            Location a = new Location(2, 1);
            Location b = new Location(1, 2);

            Assert.IsFalse(a == b);
        }

        [Test]
        public void When_different_objects_are_same_value_then_inequality_operator_returns_true()
        {
            Location a = new Location(1, 2);
            Location b = new Location(1, 2);

            Assert.IsFalse(a != b);
        }

        [Test]
        public void When_different_objects_are_different_value_then_inequality_operator_returns_false()
        {
            Location a = new Location(2, 1);
            Location b = new Location(1, 2);

            Assert.IsTrue(a != b);
        }

        [Test]
        public void When_different_objects_are_same_value_then_equals_method_returns_true()
        {
            Location a = new Location(1, 2);
            Location b = new Location(1, 2);

            Assert.IsTrue(a.Equals(b));
        }

        [Test]
        public void When_different_objects_are_different_value_then_equals_method_returns_false()
        {
            Location a = new Location(1, 2);
            Location b = new Location(2, 1);

            Assert.IsFalse(a.Equals(b));
        }
    }
}
