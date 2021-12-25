using System;
using System.Text;
using ILCLC.PartialSerializables;

namespace ILCLC {
    /// <summary>
    /// IL Field Object, just a standard member variable
    /// </summary>
    public class ILField : IAccessible {
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
        /// Type of the Field
        /// </summary>
        public Type   Type;
        /// <summary>
        /// Name of the Field
        /// </summary>
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
