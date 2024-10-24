namespace Project1
{
    internal class Program
    {

        protected class newClass
        {
            int var = 10;
            static void newMethod()
            {
                Console.WriteLine(new newClass().var);
            }
        }
        public class newClass2()
        {
            public void newMethod2()
            {
                newMethod();
            }

        }
            
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            newClass2 c2 = new newClass2();
            c2.newMethod2();
        }
    }
}
