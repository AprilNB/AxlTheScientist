using System;

namespace AxlTheScientist
{
    class Program
    {
        static void Main(string[] args)
        {
            string scientistName = "Axl";
            int numberOfApplesSent = 1;
            char exhibit = 'A';
            bool appleReappeared = true;
            double numberOfApplesReturned = 1;
            decimal howMuchAppleMissing = 0.25m;

            Console.WriteLine($"{scientistName} the scientist performed an expiriment.  He successfully teleported {numberOfApplesSent} whole apple.  It is {appleReappeared} that {numberOfApplesReturned} apple reappeared.  Yet, when the apple returned there was {howMuchAppleMissing} eaten.  He called his expiriment: exhibit {exhibit}, they do exist!");
        }
    }
}
