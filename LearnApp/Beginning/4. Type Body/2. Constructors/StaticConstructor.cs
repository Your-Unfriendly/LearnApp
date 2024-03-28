namespace LearnApp.Beginning.TypeBody.Constructors
{
    public class StaticConstructor
    {
        // Будет переопределять в статическом конструкторе, хоть это и не показано.
        private static readonly int _exampleNumber = 3;

        private static readonly int _superPuperNumber;

        /*
         * Вызывается при первом обращении к классу, недоступны нестатические переменные и методы.
         * Доступно переопределение статичных readonly членов класса.
        */
        static StaticConstructor()
        {
            _superPuperNumber = 7;

            ExampleMethod();
        }

        public static void C()
        {

        }

        private static void ExampleMethod()
        {
            Console.WriteLine("{0}: {1} & {2}", typeof(StaticConstructor), _exampleNumber, _superPuperNumber);
        }
    }
}
