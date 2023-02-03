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
                "Enter 2 : For Last Name." +
                "Enter 3 :For Email Id." +
                "Enter 4 :For Mobile Number." +
                "Enter 5: For Passwoard (minimum 8 Character ).");
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
                    case 4:
                        UserDetails.MobileNumber();
                        break;
                    case 5:
                        UserDetails.PassMin8Char();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
    }
}
