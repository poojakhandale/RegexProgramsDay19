// See https://aka.ms/new-console-template for more information
using static RegularExpression.UserValidation;

public class Program
{
    public static void Main(string[] args)
    {
        User userinfo = new User();
        Console.WriteLine("enter your email: ");
        string email = Console.ReadLine();
        Boolean value = userinfo.Validatemail(email);

        if (value)
        {
            Console.WriteLine("valid email");
        }
        else
        {
            Console.WriteLine("invalid email");
        }
    }
}

