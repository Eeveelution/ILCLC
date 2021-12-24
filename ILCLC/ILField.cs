using System;
using System.Text;

namespace ILCLC {
    public class ILField {
        public bool   Public;
        public bool   Private;
        public bool   Static;
        public Type   Type;
        public string Name;

        public override string ToString() {
            StringBuilder builder = new StringBuilder(".field");

            //Accessability Modifiers
            if (this.Public && !this.Private)
                builder.Append($"public ");
            if (this.Private && !this.Public)
                builder.Append($"private ");
            if (this.Static)
                builder.Append($"static ");

            //Type
            builder.Append(this.Type.ILSerialize());

            //Method Name
            builder.Append(" " + this.Name);

            return builder.ToString();
        }
    }
}
