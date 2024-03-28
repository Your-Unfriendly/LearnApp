using LearnApp.Beginning.TypeBody.Constructors;
using LearnApp.Beginning.TypeBody.Methods;

namespace LearnApp
{
    public class Program
    {
        private static void Main()
        {
            TestConstructors();

            TestMethods();

            Console.WriteLine("Привет, мир!");
        }

        private static void TestConstructors()
        {
            StaticConstructor.C();

            StandartConstructor w = new(2, 4);

            var a = new StandartConstructor(2, 1);

            a.Sum();
        }

        private static void TestMethods()
        {
            Methods methods = new Methods();

            methods.First();
        }
    }
}