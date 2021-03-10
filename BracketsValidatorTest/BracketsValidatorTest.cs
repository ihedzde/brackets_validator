using NUnit.Framework;
using BracketsValidator;
namespace BracketsValidatorTest
{
    [TestFixture]
    public class BracketsValidatorTest
    {
        private Validator _validator;
        [SetUp]
        public void Setup()
        {
           _validator = new Validator();
        }

        [Test]
        public void IsWorking_ReturnsTrue()
        {
            Assert.IsTrue(_validator.ValidateSequence("()"));
            Assert.IsTrue(_validator.ValidateSequence("(())((()())())"));
        }
        [Test]
        public void IsWorking_ReturnsFalse()
        {
            Assert.IsFalse(_validator.ValidateSequence("("));
            Assert.IsFalse(_validator.ValidateSequence(")(()))"));
            Assert.IsFalse(_validator.ValidateSequence(null));
        }
    }
}