using System;
 internal class Program
{
    #region Q2: Container
    class Container<T>
    {
        private List<T> _items = new();
        public void Add(T item) => _items.Add(item);
        public T Get(int index) => _items[index];
    }

    #endregion
    public static void Main(string [] args)
    {
        #region Q1: Generic class

        /*
A class with a type placeholder (T) that is replaced by a real type when used, like:  List<int>.
Why use generics: type safety at compile time, code reuse, no casting, and no boxing (better performance).
         */
        #endregion

   
    }
}