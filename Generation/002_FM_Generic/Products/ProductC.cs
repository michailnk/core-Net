namespace _002_FM_Generic.Products
{
    public class ProductC:IProduct
    {
        public override string ToString() {
            return this.GetType().Name;
        }
    }
}
