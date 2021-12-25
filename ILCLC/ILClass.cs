using System.Collections.Generic;
using System.Text;
using ILCLC.PartialSerializables;

namespace ILCLC {
    public class ILClass : IAccessible {
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
        /// Name of the Class
        /// </summary>
        public string Name;

        /// <summary>
        /// All the Fields present in the Class
        /// </summary>
        public List<ILField> Fields;
        /// <summary>
        /// All the Methods present in the Class
        /// </summary>
        public List<ILMethod> Methods;

        public override string ToString() {
            StringBuilder builder = new StringBuilder(".class ");

            builder.Append((this as IAccessible).GetAccessabilityModifiers());

            return builder.ToString();
        }

    }
}
