namespace LearnApp.Beginning.TypeBody.Types
{
    // Может быть null.
    // Храниться в куче.
    public class Class
    {
        private int _a;

        public Class(int a) => _a = a;

        public void A()
        {
            Console.WriteLine("{0}: {1}", GetType(), _a);
        }
    }
}
