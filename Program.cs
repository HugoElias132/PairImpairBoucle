namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        string answer = "";
        do
        {
            Console.WriteLine("donnez moi un nombre entier");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("le nombre " + number + " est pair");
            }
            else
            {
                Console.WriteLine("le nombre " + number + " est impair");
            }
            Console.WriteLine("voulez-vous vérifier un autre nombre? (y/n)");
            answer = Console.ReadLine();
        } while (answer == "y");
    }
}
    