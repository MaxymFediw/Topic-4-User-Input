namespace Topic_4_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Console.WriteLine();

            // Console.WriteLine("Press ENTER To Continue");
            // string username;

            // username = Console.ReadLine();

            // Console.Write("Enter Username:");
            // username = Console.ReadLine();


            // Console.WriteLine("You're Username is: " + username + ".");
            // Console.WriteLine(); 
            //Console.WriteLine("Press ENTER To Continue");
            // Console.WriteLine("");
            // Console.ReadLine();



            //int age;



            // Console.Write("Enter age: ");

            // age = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("You're age is: " + age + ".");
            // Console.ReadLine();

            // //Making it so we can write letters in age bracket.

            // Console.WriteLine("Enter Age: ");
            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));

            // Console.WriteLine("You're age is: " +age + ".");
            // Console.ReadLine();

            // //price part now:

            // double price;

            // Console.WriteLine("What is the price?");
            // Double.TryParse(Console.ReadLine(), out price);
            // Console.WriteLine("The price is " + price.ToString("C"));

            

            //double price, discount, finalPrice;
            //Console.WriteLine("What is the price?");
            //Double.TryParse(Console.ReadLine(), out price);
            //discount = .5 * price;
            //finalPrice = price - discount;
            //Console.WriteLine("The price is " + finalPrice.ToString("C"));

            //tasks

            //#1:

            string name;

            Console.WriteLine("What's your name? ");
            name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " +name + ".");

            string topping;
          
            Console.WriteLine("What's your favourite pizza topping?");
            topping = Console.ReadLine();

            Console.WriteLine("Wow, " + name + "! " + topping + " Is my favourite pizza topping, too!");

            //#2

            string item;

            double price, finalCost;

            Console.WriteLine("So! What is the item you'd like to buy?");
            item = Console.ReadLine();

            Console.WriteLine("And how much does that set you back at Walmart?");
            Double.TryParse(Console.ReadLine(), out price);

            finalCost = 3 * price;

            Console.WriteLine("Alrighty, So-If you bought 3 " + item + "'s, it'll set ya back $" + finalCost +".");

            












        }
    }
}
