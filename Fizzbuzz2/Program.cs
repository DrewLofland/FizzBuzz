namespace Fizzbuzz2
{
    internal class Program
    {




        static void Main(string[] args)
        {

            //enter an integer
            Console.WriteLine($"enter number");
            var input = int.Parse(Console.ReadLine());

            //test if integers are divisible by 3 and or 5
            Console.WriteLine(Whiteboard(input));
        }


        public static string Whiteboard(int x)
        {
            //test if integers are divisible by 3 and or 5 method
            if ((x % 3 == 0) && (x % 5 == 0))
            {
                return "fizzbuzz";
            }

            else if (x % 3 == 0)
            {
                return "fizz";
            }
            else if (x % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return "nothing";
            }

        }
    }



}

