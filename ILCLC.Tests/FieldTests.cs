using System;
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
            string gotPrimitiveFieldValue = primitiveTypeField.ToString();

            Assert.AreEqual(expectedPrimitiveFieldValue, gotPrimitiveFieldValue);

            Console.WriteLine(gotPrimitiveFieldValue);

            ILField complexTypeField = new ILField {
                Name    = "ServerStream",
                Private = true,
                Public  = false,
                Static  = false,
                Type    = typeof(MemoryStream)
            };

            string expectedComplexFieldValue = $".field private [System.Private.CoreLib]MemoryStream ServerStream";
            string gotComplexFieldValue = complexTypeField.ToString();

            Assert.AreEqual(expectedComplexFieldValue, gotComplexFieldValue);

            Console.WriteLine(gotComplexFieldValue);

            Assert.Pass();
        }
    }
}
