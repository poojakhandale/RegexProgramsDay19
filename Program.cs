// See https://aka.ms/new-console-template for more information
using static RegularExpression.UserValidation;

public class Program
{
    public static void Main(string[] args)
    {
        User userinfo = new User();
        Console.WriteLine("enter your number");
        string num = Console.ReadLine();
        Boolean value = userinfo.validNumber(num);

        if (value)
        {
            Console.WriteLine("valid Number");
        }
        else
        {
            Console.WriteLine("invalid Number");
        }
    }
    }


