using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILCLC {
    public static class TypeHelpers {
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

        public static string ILSerialize(this Type type) {
            if (type.IsPrimitive)
                return PrimitiveTypes.GetValueOrDefault(type, "<what.the.fuck/<.>>");

            return $"[{type.Assembly.GetName().Name}]{type.Name}";
        }
    }
}
