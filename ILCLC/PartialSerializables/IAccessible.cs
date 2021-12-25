using System.Text;

namespace ILCLC.PartialSerializables {
    /// <summary>
    /// Helps to avoid code duplication, as alot of IL Objects have Accessibility modifiers
    /// </summary>
    public interface IAccessible {
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
        /// Serializes all of the Accessibility Modifiers
        /// </summary>
        /// <returns>A valid IL String with all of 'em</returns>
        public string GetAccessabilityModifiers() {
            StringBuilder builder = new StringBuilder();

            if (this.Public && !this.Private)
                builder.Append($"public ");
            if (this.Private && !this.Public)
                builder.Append($"private ");
            if (this.Static)
                builder.Append($"static ");

            return builder.ToString();
        }
    }
}
