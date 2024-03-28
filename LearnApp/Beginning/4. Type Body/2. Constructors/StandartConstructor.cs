using LearnApp.Beginning.TypeBody.Types;

namespace LearnApp.Beginning.TypeBody.Constructors
{
    public class StandartConstructor
    {
        // Работает также как и в статическом конструкторе.
        private readonly int _a;
        private int _b;

        // Вызывается при создании экземпляра класса.
        public StandartConstructor(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public void Sum() => Console.WriteLine("Сумма равна ({0}): {1} ({2} + {3})", GetType(), _a + _b, _a, _b);
    }
}
