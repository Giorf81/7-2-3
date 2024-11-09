namespace _7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Baseclass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : Baseclass 
    {
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
