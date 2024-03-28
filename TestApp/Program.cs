using LearnApp.Beginning.AccessModifiers;
using LearnApp.Beginning.TypeBody.Constructors;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение для теста окончено!");
        }

        public static void CheckAccessModifiers()
        {
            PublicClass publicClass = new PublicClass();

            // Ошибка так как он виден только внутри проекта LearnApp, можно исправить с помощью [assembly: InternalsVisibleTo("TestApp")]
            // InternalClass internalClass = null;
        }
    }
}
