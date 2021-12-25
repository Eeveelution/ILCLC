using System.Text;

namespace ILCLC.PartialSerializables {
    public interface IAccessible {
        public bool Public { get; set; }
        public bool Private { get; set; }
        public bool Static { get; set; }

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
