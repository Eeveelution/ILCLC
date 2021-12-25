using System;
using System.Collections.Generic;
using System.Text;
using ILCLC.PartialSerializables;
using ILCLC.Structs;

namespace ILCLC {
    /// <summary>
    /// A IL Method, or Function if you prefer
    /// </summary>
    public class ILMethod : IAccessible {
        /// <summary>
        /// Accessibility Modifier, is it public?
        /// </summary>
        public bool Public { get; set; }
        /// <summary>
        /// Accessibility Modifier, is it private?
        /// </summary>
        public bool Private { get; set; }
        /// <summary>
        /// Accessibility Modifier, is it static? or in other words, is it part of the Class or the Class instance?
        /// </summary>
        public bool Static { get; set; }
        /// <summary>
        /// Is this the Method where the Program begins?
        ///
        /// Internal to prevent people from shooting themselves in the foot by having multiple EntryPoint ILMethods
        /// </summary>
        internal bool             EntryPoint;
        /// <summary>
        /// What type does it return
        /// </summary>
        public   Type             ReturnType;
        /// <summary>
        /// Input Arguments that are required to be passed when calling the function
        /// </summary>
        public   List<ILTypeName> InputArguments;
        /// <summary>
        /// Local Variables of the function
        /// </summary>
        public   List<ILTypeName> LocalVariables;
        /// <summary>
        /// Name of the Function
        /// </summary>
        public   string           Name;
        /// <summary>
        /// Serializes the ILMethod
        /// </summary>
        /// <returns>IL Code for the function</returns>
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
