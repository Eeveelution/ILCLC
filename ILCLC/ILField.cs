using System;
using System.Text;
using ILCLC.PartialSerializables;

namespace ILCLC {
    public class ILField : IAccessible {
        public bool Public { get; set; }
        public bool Private { get; set; }
        public bool Static { get; set; }
        public Type   Type;
        public string Name;

        public override string ToString() {
            StringBuilder builder = new StringBuilder(".field ");

            //Accessability Modifiers
            builder.Append((this as IAccessible).GetAccessabilityModifiers());

            //Type
            builder.Append(this.Type.ILSerialize());

            //Method Name
            builder.Append(" " + this.Name);

            return builder.ToString();
        }
    }
}
