using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

namespace ILCLC {
    public class ILAssembly {
        public List<ILClass> Classes = new();

        public void ExportAsIL() {
            Assembly assembly = Assembly.GetExecutingAssembly();
        }
    }
}
