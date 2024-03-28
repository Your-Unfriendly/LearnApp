namespace LearnApp.Beginning.TypeBody.Methods
{
    public class Methods
    {
        // Объявляется как переменные, дает понять что метод с помощью круглых скобочек, может возвращать void (ничего).
        public void First()
        {
            int a = 3;

            Console.WriteLine("First: {0}", a);

            // Передает значение переменной.
            Second(a);

            Console.WriteLine("First: {0}", a);

            // Передает ссылку на переменную.
            Third(ref a);

            Console.WriteLine("First: {0}", a);

            Fourth();

            Fifth();
            Fifth(1);
            Fifth(2, "", string.Empty, 'c', 4, 5.8);
        }

        // Может содержать аргументы.
        public void Second(int num)
        {
            Console.WriteLine("Second: {0}", num);

            num = 2;

            Console.WriteLine("Second: {0}", num);
        }

        // Аргумент может быть ссылкой (ref или out), при изменении меняется и переданная при вызове переменная.
        public void Third(ref int num)
        {
            Console.WriteLine("Third: {0}", num);

            num = 7;

            Console.WriteLine("Third: {0}", num);
        }

        // Аргумент может быть необязателен, тогда можно его не задавать, будет принято стандартное значение.
        // Задается с помощью =, где правая часть выражения является константой.
        // Необязательные аргументы должны быть в конце.
        public void Fourth(int num = 10)
        {
            Console.WriteLine("Fourth: {0}", num);
        }

        // params всегда идет с массивом, позволяет задать N (неизвестное) элементов, может быть как один объект так и массив из 100+ элементов, или вовсе не быть.
        public void Fifth(params object[] objects)
        {
            Console.WriteLine("Fifth: {0}", objects.Length);
        }
    }
}
