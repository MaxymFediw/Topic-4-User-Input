namespace Topic_4_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine();

            Console.WriteLine("Press ENTER To Continue");
            string username;

            username = Console.ReadLine();

            Console.Write("Enter Username:");
            username = Console.ReadLine();

            
            Console.WriteLine("You're Username is: " + username + ".");
            Console.WriteLine(); 
           Console.WriteLine("Press ENTER To Continue");
            Console.WriteLine("");
            Console.ReadLine();

            

           string age;

            age= Console.ReadLine();

            Console.Write("Enter age: ");

            age= Console.ReadLine();
            Console.WriteLine("You're age is: " + age + ".");
            Console.ReadLine();










        }
    }
}
