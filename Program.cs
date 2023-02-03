using UserRegistrationRegex;

namespace UserRegistractionRegex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            while (true)
            {
                Console.WriteLine("Please select any one from below :\n" +
                "Enter 1 : For First Name." +
                "Enter 2 : For Last Name");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    case 3:
                        UserDetails.Emailid();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
    }
}
