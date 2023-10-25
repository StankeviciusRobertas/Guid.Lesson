namespace GuidLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            var cardGuid = Guid.Parse(Console.ReadLine());
        }
    }
}