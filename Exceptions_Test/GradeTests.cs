using NUnit.Framework;
using ExceptionsApp;
using System;

namespace Exceptions_Test
{
    public class Tests
    {
        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenTheMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            //Assert.That(() => Program.Grade(mark) Throws.TypeOf<ArgumentOutOfRangeException>();
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>()
                .With.Message.Contain("Allowed range 0=100"));
        }

        [TestCase(101)]
        [TestCase(5000)]
        public void WhenTheMarkIsGreaterThan100_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>()
                .With.Message.Contain("Allowed range 0=100"));
        }

    }
}