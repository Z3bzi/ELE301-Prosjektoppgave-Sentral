namespace Sentral
{
    internal class SENTRAL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User Ola = new("ola", "nordmann", "ola@nordmann.no", new Card(12));
            //TEST

            Ola.Info();
        }
    }
}
