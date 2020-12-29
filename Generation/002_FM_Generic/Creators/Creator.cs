using System;

namespace _002_FM_Generic.Creators
{
    public class Creator : ICreator {
        public T CreateProd<T>() {
            return Activator.CreateInstance<T>();
        }
    }
}
