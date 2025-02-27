namespace AccessConstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B InstanceofB = new B();
            Console.WriteLine($"{B.InstanceOfA.a} {B.InstanceOfA.b}");
        }
    }
}
