using LearnApp.Beginning;
using LearnApp.Beginning.TypeBody.Constructors;
using LearnApp.Beginning.TypeModifiers.Static;

namespace LearnApp
{
    public class Program
    {
        private int _b;

        internal int A { get; set; }

        private static void Main()
        {
            TestConstructors();

            Console.WriteLine("Привет, мир!");
        }

        private static void TestConstructors()
        {
            StaticConstructor.C();

            StandartConstructor w = new(2, 4);

            var a = new StandartConstructor(2, 1);

            a.Sum();
        }
    }
}