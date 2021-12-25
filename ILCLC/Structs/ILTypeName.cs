using System;
using System.Text;

namespace ILCLC.Structs {
    /// <summary>
    /// Helper Struct that contains both a Name and a Type
    /// </summary>
    public struct ILTypeName {
        public string Name;
        public Type   Type;

        public override string ToString() {
            StringBuilder builder = new StringBuilder();

            builder.Append(this.Type.ILSerialize() + " ");
            builder.Append(this.Name               + " ");

            return builder.ToString();
        }
    }
}
