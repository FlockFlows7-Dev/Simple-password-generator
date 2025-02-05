using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        Random random = new Random();
        int Passwordlength = 0;
        

        void generateNum()
        {
            int randomNum = random.Next(numbers.Length);
            Console.Write(numbers[randomNum]);
        }

        void generatePassword() 
        {
            for (int i = 0; i < Passwordlength; i++) 
            {
                generateNum();
            }
        }

        void regenerate() 
        {
            Console.Clear();
            Console.WriteLine("How many digits?");
            Passwordlength = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Password: "); generatePassword();
            Console.WriteLine("");
            Console.WriteLine("(Press enter to regenerate again.)");
            Console.ReadLine();
            regenerate();
        }

        Console.WriteLine("How many digits?");
        Passwordlength = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Password: "); generatePassword();
        Console.WriteLine("");
        Console.WriteLine("(Press enter to regenerate.)");
        Console.ReadLine();
        regenerate();
    }
}