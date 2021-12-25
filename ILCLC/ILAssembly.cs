using System.Collections.Generic;

namespace ILCLC {
    /// <summary>
    /// IL Assembly
    /// </summary>
    public class ILAssembly {
        /// <summary>
        /// All Available Classes in the Assembly
        /// </summary>
        public  List<ILClass>  Classes = new();
        /// <summary>
        /// All the Available top level Methods in the Assembly
        /// </summary>
        public  List<ILMethod> Methods = new();
        /// <summary>
        /// Entry Point Method
        /// </summary>
        private ILMethod       _entryPoint;
        /// <summary>
        /// Exports the entire Assembly as IL
        /// </summary>
        public string ExportAsIL() {
            return "";
        }

        public void SetEntrypoint(ILMethod method) {
            if (this._entryPoint != null)
                this._entryPoint.EntryPoint = false;

            this._entryPoint             = method;
        }
    }
}
