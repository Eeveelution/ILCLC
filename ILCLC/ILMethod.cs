using System;
using System.Collections.Generic;
using System.Text;
using ILCLC.PartialSerializables;
using ILCLC.Structs;

namespace ILCLC {
    public class ILMethod : IAccessible {
        public bool Public { get; set; }
        public bool Private { get; set; }
        public bool Static { get; set; }
        internal bool             EntryPoint;
        public   Type             ReturnType;
        public   List<ILTypeName> InputArguments;
        public   List<ILTypeName> LocalVariables;
        public   string           Name;

        public override string ToString() {
            StringBuilder builder = new(".method ");

            //Accessability Modifiers
            builder.Append((this as IAccessible).GetAccessabilityModifiers());

            //Return Type
            builder.Append(this.ReturnType.ILSerialize());

            //Method Name
            builder.Append(" " + this.Name);

            //Argument List Begin
            builder.Append("( ");

            for (int i = 0; i != this.InputArguments.Count; i++) {
                ILTypeName currentArgument = this.InputArguments[i];

                builder.Append(currentArgument.ToString());

                if (i != this.InputArguments.Count - 1)
                    builder.Append(", ");
            }

            //Argument List End, and hint that this is CIL
            builder.Append(") cil managed ");

            //Beginning of Function
            builder.Append("{ ");

            //Defining Local Variables
            builder.Append(".locals init ( ");

            for (int i = 0; i != this.LocalVariables.Count; i++) {
                ILTypeName currentArgument = this.LocalVariables[i];

                //IL Locals require an Index, a type, and a optional name
                builder.Append($"[{i}] ");
                builder.Append(currentArgument.ToString());

                if (i != this.LocalVariables.Count - 1)
                    builder.Append(", ");
            }

            //End of Defining Local Variables
            builder.Append(") ");

            //If this is the Entry Point of the Assembly, make sure to tell IL
            if(this.EntryPoint)
                builder.Append(".entrypoint");

            //End of Function
            builder.Append("} ");

            return builder.ToString();
        }
    }
}
