using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions
{
    [TestClass]
    public class StringRotationTest
    {
        private StringRotation sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new StringRotation();
        }

        [TestMethod]
        public void TestIsRotation()
        {
            // Arrange
            var s1 = "waterbottle";
            var s2 = "erbottlewat";

            // Act
            var result = sut.IsRotation(s1, s2);

            // Assert
            result.ShouldBeTrue();
        }
    }
}
