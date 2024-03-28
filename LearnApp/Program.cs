using LearnApp.Beginning.TypeBody.Constructors;
using LearnApp.Beginning.TypeBody.Methods;

namespace LearnApp
{
    public class Program
    {
        private static readonly List<ConsoleColor> _colors;
        private static readonly Random _random;

        static Program()
        {
            _random = new();
            _colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
        }

        private static void Main()
        {
            Console.ForegroundColor = _colors.ElementAt(_random.Next(0, _colors.Count()));

            Console.WriteLine("Тесты конструкторов:");

            TestConstructors();

            UpdateConsole();

            Console.WriteLine("Тесты методов:");

            TestMethods();

            UpdateConsole();

            Console.WriteLine("Вывод и ввод:");

            Console.WriteLine("Привет, мир!\nВведи что-либо:");

            Console.WriteLine("Ты ввел: {0}", Console.ReadLine());

            Console.ReadLine();
        }

        private static void UpdateConsole()
        {
            Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = _colors.ElementAt(_random.Next(0, _colors.Count));
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