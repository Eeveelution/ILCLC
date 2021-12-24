using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ILCLC.Tests {
    public class MethodTests {
        [SetUp]
        public void Setup() {}

        [Test]
        public void CreateSimpleMethod() {
            ILMethod method = new ILMethod {
                Name = "Main",
                Private = false,
                Public = true,
                Static = true,
                ReturnType = typeof(void),
                InputArguments = new List<ILTypeName>() {
                    new ILTypeName {
                        Name = "args",
                        Type = typeof(string[])
                    }
                },
                LocalVariables = new List<ILTypeName> {
                    new ILTypeName {
                        Name = "Test",
                        Type = typeof(string)
                    }
                }
            };

            Console.WriteLine(method.ToString());

            Assert.Pass();
        }
    }
}
