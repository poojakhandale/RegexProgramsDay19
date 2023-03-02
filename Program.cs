// See https://aka.ms/new-console-template for more information
using static RegularExpression.UserValidation;

public class Program
{
    public static void Main(string[] args)
    {
        User userinfo = new User();
        Console.WriteLine("enter your password");
        string Password = Console.ReadLine();
        Boolean value = userinfo.validPassWord(Password);

        if (value)
        {
            Console.WriteLine("valid password");
        }
        else
        {
            Console.WriteLine("invalid password");
        }
    }
}
    




