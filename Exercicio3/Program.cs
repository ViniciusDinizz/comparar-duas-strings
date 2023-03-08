internal class Program
{
    private static void Main(string[] args)
    {
        string primeira, segunda;

        Console.Write("Primeira string: ");
        primeira = Console.ReadLine();
        Console.Write("Segunda string: ");
        segunda = Console.ReadLine();

        if(primeira.Equals(segunda))
        {
            Console.WriteLine("São iguais.");
        }
        else
        {
            Console.WriteLine("São diferentes.");
        }

       /* bool comparar(string primeira, string segunda)
        {
            if (primeira == segunda)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}