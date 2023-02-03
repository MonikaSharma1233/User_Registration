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
                "Enter 1 : For First Name.\n" +
                "Enter 2 : For Last Name.\n" +
                "Enter 3 :For Email Id.\n" +
                "Enter 4 :For Mobile Number.\n" +
                "Enter 5: For Passwoard (minimum 8 Character ).\n" +
                "Enter 6: For set Password having 8 Minimum character and at least 1 upper case in it .\n" +
                "Enter 7: For set Password having 8 min char and atleast 1 upper case 1 numeric in it.\n" +
                "Enter 8: For set Password With having Exactly 1 special Charcter.\n" +
                "Enter 9: For list of email samples validation.\n ");
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
                    case 6:
                        UserDetails.PassMin8CharAnd1UpperCase();
                        break;
                    case 7:
                        UserDetails.UpperCase1AndNumeric1();
                        break;
                    case 8:
                    retry:
                        UserDetails.SpecialCharacter1();
                        goto retry;
                        break;
                    case 9:
                        UserDetails.EmailSample();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
    }
}
