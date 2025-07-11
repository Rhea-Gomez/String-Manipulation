namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "Sachin,Aurionpro,Mumbai";
            string[] words = example.Split(',');

            Console.WriteLine("Developer name : " + words[0]);
            Console.WriteLine("Company name : " + words[1]);
            Console.WriteLine("Location : " + words[2]);
        }
    }
}
