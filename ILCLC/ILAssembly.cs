using System.Collections.Generic;

namespace ILCLC {
    public class ILAssembly {
        public  List<ILClass>  Classes = new();
        public  List<ILMethod> Methods = new();
        private ILMethod       _entryPoint;

        public void ExportAsIL() {

        }

        public void SetEntrypoint(ILMethod method) {
            if (this._entryPoint != null)
                this._entryPoint.EntryPoint = false;

            this._entryPoint             = method;
        }
    }
}
