using System.IO;
using NUnit.Framework;

namespace ILCLC.Tests {
    public class FieldTests {
        [Test]
        public void TestFieldCreation() {
            ILField primitiveTypeField = new ILField {
                Name    = "CoolVar",
                Private = false,
                Public  = true,
                Static  = true,
                Type    = typeof(string)
            };

            string expectedPrimitiveFieldValue = $".field public static string CoolVar";

            Assert.AreEqual(expectedPrimitiveFieldValue, primitiveTypeField.ToString());

            ILField complexTypeField = new ILField {
                Name    = "ServerStream",
                Private = true,
                Public  = false,
                Static  = false,
                Type    = typeof(MemoryStream)
            };

            string expectedComplexFieldValue = $".field private [System.Private.CoreLib]MemoryStream ServerStream";

            Assert.AreEqual(expectedComplexFieldValue, complexTypeField.ToString());

            Assert.Pass();
        }
    }
}
