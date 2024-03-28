namespace LearnApp.Beginning.TypeBody.Types
{
    public struct Struct
    {
        public Struct(int b) => B = b;

        public int B { get; }

        public void A()
        {
            Console.WriteLine("{0}: {1}", GetType(), B);
        }
    }
}
