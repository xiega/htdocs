namespace Klasy
{
    static class Calculations
    {
        public static T add<T>(T a,T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }
        static public int add(int x, int y)
        {
            return x + y;
        }
    }
}
