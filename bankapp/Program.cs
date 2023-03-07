namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount=0, month=0 ;
            double discount=0d, monthpay=0d ;
            double total=0d;
            Console.WriteLine("Enter username: ");
            tryagain:
            string Username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            if (Username != "admin" && password != "admin")
            {
                Console.WriteLine("not correct");
                goto tryagain;
            }
            else
            {
                Console.WriteLine("choose: \n1.Kredit goturmek.\n2.Kredit Odemek.\n3.Hesabat");
                string secimler = Console.ReadLine();
                
                switch (secimler)
                {
                        case "1":
                        Console.WriteLine("Choose Month");
                        month = int.Parse(Console.ReadLine());
                        if (month > 0 && month <= 12)
                        {
                            Console.WriteLine("Meblegi Daxil et");
                            amount = int.Parse(Console.ReadLine());
                            Console.WriteLine("12% faiz");
                            discount = (double)(amount * 0.12);
                            total = (double)(amount + discount);
                            Console.WriteLine(total);
                        }
                        else
                        {

                            Console.WriteLine("18% faiz");
                            discount = (double)(amount * 0.18);
                            total = (double)(amount + discount);
                            Console.WriteLine(total);
                        }
                        break;
                        case "2":
                        Console.WriteLine("Kredit Odemek");
                        break;
                        case "3":
                        Console.WriteLine("Hesabat");
                        break;
                        default:
                        break;
                }
            }
        }
    }
}