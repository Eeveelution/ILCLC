using System;
using System.Collections.Generic;

namespace ILCLC {
    public static class TypeHelpers {
        /// <summary>
        /// A Dictionary to Translate between C# Types and IL Types
        /// </summary>
        public static Dictionary<Type, string> PrimitiveTypes = new() {
            {
                typeof(bool), "bool"
            }, {
                typeof(char), "char"
            }, {
                typeof(object), "object"
            }, {
                typeof(string), "string"
            }, {
                typeof(float), "float32"
            }, {
                typeof(double), "float64"
            }, {
                typeof(sbyte), "int8"
            }, {
                typeof(short), "int16"
            }, {
                typeof(int), "int32"
            }, {
                typeof(long), "int64"
            }, {
                typeof(nint), "native int"
            }, {
                typeof(nuint), "native unsigned int"
            }, {
                typeof(TypedReference), "typedref"
            }, {
                typeof(byte), "unsigned int8"
            }, {
                typeof(ushort), "unsigned int16"
            }, {
                typeof(uint), "unsigned int32"
            }, {
                typeof(ulong), "unsigned int16"
            },
        };
        /// <summary>
        /// Serializes a Type to a IL Valid Typename
        /// </summary>
        /// <param name="type"></param>
        /// <returns>IL Type</returns>
        public static string ILSerialize(this Type type) {
            if (type.IsPrimitive || PrimitiveTypes.ContainsKey(type))
                return PrimitiveTypes.GetValueOrDefault(type, "<what.the.fuck/<.>>");

            return $"[{type.Assembly.GetName().Name}]{type.Name}";
        }
    }
}
