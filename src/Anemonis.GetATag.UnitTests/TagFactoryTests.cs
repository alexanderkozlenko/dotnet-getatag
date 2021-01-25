using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anemonis.GetATag.UnitTests
{
    [TestClass]
    public sealed class TagFactoryTests
    {
        [TestMethod]
        public void CreateWhenSizeIsZero()
        {
            var source = "The quick brown fox jumps over the lazy dog.";

            var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => TagFactory.Create(0, source));

            Assert.IsNotNull(exception.Message);
            Assert.AreEqual(0, exception.ActualValue);
        }

        [TestMethod]
        public void CreateWhenTextIsNotNull()
        {
            var source = "The quick brown fox jumps over the lazy dog.";
            var target = "wrfz8ay";

            var result = TagFactory.Create(4, source);

            Assert.AreEqual(target, result);
        }
    }
}
