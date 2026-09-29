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

    #region Q3: Multiple type parameters
    //A generic type can have more than one placeholder.
    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public Pair(TFirst first, TSecond second) { First = first; Second = second; }
    }

    #endregion

    #region Q4: Generic method and Swap
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a; a = b; b = temp;
    }
    #endregion

    #region  Q5: FindMax
    static T FindMax<T>(T[] items) where T : IComparable<T>
        // Generic doesn't allow for comparison so that we write where T : IComparable<T>
    {
        T max = items[0];
        foreach (var item in items)
            if (item.CompareTo(max) > 0) max = item;
        return max;
    }
    #endregion

    #region Q6: Generic interface and IRepository
    // An interface with a type parameter.
    interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
    // all this methodes will be impelemented in another class , it's only the signature
    #endregion

    #region Q7: struct constraint
    //T must be a non-nullable value type.
    class costrain_Struct<T> where T : struct { public T Value; }
    // costrain_Struct<int> OK, costrain_Struct<string> error
    #endregion

    #region Q8: class constraint
    //T must be a reference type.
    class Class_Constrains<T> where T : class { public T? Item; }
    // Class_Constrains<string> OK, Class_Constrains<int> error
    #endregion

    #region Q9: new() constraint
    //T must have a public parameterless constructor.
    static T Create<T>() where T : new() => new T();
    #endregion

    #region Q10: Interface constraint
    //T must implement the interface.
    interface IShape { double Area(); }
    static double GetArea<T>(T shape) where T : IShape => shape.Area();
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