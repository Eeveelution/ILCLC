using System.Collections.Generic;
using System.Text;
using ILCLC.PartialSerializables;

namespace ILCLC {
    public class ILClass : IAccessible {
        public bool Public { get; set; }
        public bool Private { get; set; }
        public bool Static { get; set; }
        public string Name;

        public List<ILField> Fields;
        public List<ILMethod> Methods;

        public override string ToString() {
            StringBuilder builder = new StringBuilder(".class ");

            builder.Append((this as IAccessible).GetAccessabilityModifiers());

            return builder.ToString();
        }

    }
}
