using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserDetails
    {
        public static void FirstName()
        {
            Console.WriteLine("Enter your FirstName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            // first lettr should be cap and next thre can be small ^ and $ rule of regex pattern 
            Iteration(userInput, regexCondition);
        }
        public static void LastName()
        {
            Console.WriteLine("Enter your Last Name");
            string userInput = Console.ReadLine();
            // first lettr should be cap and next thre can be small ^ and $ rule of regex pattern 
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Emailid()
        {
            Console.WriteLine("Enter Your Email Id");
            string userInput = Console.ReadLine();
            //first char can be atoz and 0to9 no  and there should be on spl charwith it 
            //one [@] should be present one dot should be present 
            // 2,3 char of [atoz and Ato Z]  then dot will be there or can se @gmail.com should be there
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3})";
            Iteration(userInput, regexCondition);
        }
        public static void MobileNumber()
        {
            Console.WriteLine("Enter Your Mobile Number");
            string userInput = Console.ReadLine();
            //Add 9 and 1 as first two integers should be atmost one and one space required first integer of no cannot be 0 
            //then last 9 digits can be any int
            string regesCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            Iteration(userInput, regesCondition);
        }
        public static void PassMin8Char()
        {
            Console.WriteLine("Enter your Passwoard");
            string userInput = Console.ReadLine();
            //length should be 8 char min and should have conbination of  small a to z and A to Z 
            string regexCondition = "^[a-zA-ZO-9]{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8CharAnd1UpperCase()
        {
            Console.WriteLine("Enter Your Password");
            string userInput = Console.ReadLine();
            //One should be uperletter atleast one = *
               
            Iteration(userInput, regexCondition);
        }
        public static void UpperCase1AndNumeric1()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            //altleast one number
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1}[a-zA-ZO-9]{6,}$";
            Iteration(userInput, regexCondition);
        }

        public static void SpecialCharacter1()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            //Give some special char
            string regexCondition = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            Iteration(userInput, regexCondition);
        }
        //Pending to understand

        public static void EmailSample()
        {
            string[] userInput = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                "abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
                                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com",
                                "abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            foreach (string input in userInput)
            {
                if (Regex.IsMatch(input, regexCondition))
                {
                    Console.WriteLine($"{input} --> Valid");
                }
                else
                {
                    Console.WriteLine($"{input} --> Invalid");
                }
            }
        }

        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}
