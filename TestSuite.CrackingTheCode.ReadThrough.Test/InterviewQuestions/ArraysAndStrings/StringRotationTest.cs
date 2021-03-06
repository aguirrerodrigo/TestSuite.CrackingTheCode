﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using TestSuite.CrackingTheCode.ReadThrough.InterviewQuestions.ArraysAndStrings;

namespace TestSuite.CrackingTheCode.ReadThrough.Test.InterviewQuestions.ArraysAndStrings
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

        [TestMethod]
        public void TestIsRotation_DifferentLength()
        {
            // Arrange
            var s1 = "waterbottlew";
            var s2 = "erbottlewat";

            // Act
            var result = sut.IsRotation(s1, s2);

            // Assert
            result.ShouldBeFalse();
        }
    }
}
