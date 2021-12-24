using System.Collections.Generic;

namespace ILCLC {
    public class ILClass {
        public bool   Public;
        public bool   Private;
        public bool   Static;
        public string Name;

        public List<ILField> Fields;
        public List<ILMethod> Methods;


    }
}
