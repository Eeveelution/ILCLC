using System;
using System.Text;

namespace ILCLC.Structs {
    public struct ILTypeName {
        public string Name;
        public Type   Type;

        public override string ToString() {
            StringBuilder builder = new StringBuilder();

            builder.Append(this.Type.FullName + " ");
            builder.Append(this.Name          + " ");

            return builder.ToString();
        }
    }
}
