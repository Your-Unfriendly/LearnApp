namespace LearnApp.Beginning.TypeBody.Fields
{
    public class Fields
    {
        // Объявляется как лолькальная переменная, но может иметь модификатор доступа и доступна согласна нему даже из других классов (если public или internal).
        private int number;

        // Принято чтобы они были приватными, в таком случае нужно добавлять нижнее подчеркивание чтобы не было конфузов с локальными переменными или аргументами.
        private int _secondNumber;

        public Fields(int number, int secondNumber)
        {
            // Требуется this, так как иначе мы переопределеяем значение аргумента number на него же.
            this.number = number;

            // Не требуется this, так как нижнее подчеркивание позволяет отличить переменные.
            _secondNumber = secondNumber;
        }

        public void A()
        {
            // Локальная переменная.
            int a = default;

            Console.WriteLine(number + " " + _secondNumber + " " + a);
        }
    }
}
