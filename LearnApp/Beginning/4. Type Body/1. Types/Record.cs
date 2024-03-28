namespace LearnApp.Beginning.TypeBody.Types
{
    // Является либо классом либо структурой.
    // Сразу определяет конструктор и некоторые интерфейсы за тебя.
    public record Record(int a)
    {
        public void A()
        {
            Console.WriteLine("{0}: {1}", GetType(), a);
        }
    }
}
