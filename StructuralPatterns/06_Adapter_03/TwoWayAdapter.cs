
namespace _06_Adapter_03 {
    class TwoWayAdapter : IOldInterface, INewInterface {
        dynamic adaptee = null;
        void INewInterface.MethodNew() {
            if (adaptee == null)
                this.adaptee = new NewRealisation();
            this.adaptee.MethodNew();

        }

        void IOldInterface.OldMethod() {
            if (adaptee == null)
                this.adaptee = new OldRealisation();
            this.adaptee.OldMethod();
        }
    }
}
