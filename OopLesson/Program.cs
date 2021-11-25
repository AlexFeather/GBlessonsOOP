using OopLesson.lesson7;

namespace OopLesson
{
    public class Program
    {

        public enum AccountType
        {
            Debit = 0,
            Savings = 1
        }
        static void Main(string[] args)
        {
            BCoder bc = new BCoder();

            var encoded = bc.Encode("alexfeather");
            System.Console.WriteLine(encoded);
            System.Console.WriteLine(bc.Decode(encoded));
        }
    }
}
