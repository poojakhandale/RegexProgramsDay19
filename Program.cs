// See https://aka.ms/new-console-template for more information
using static RegularExpression.UserValidation;

public class Program
{
    public static void Main(string[] args)
    {
        User userinfo = new User();
        Boolean Firstname = userinfo.ValidateFirstName("Zeus");
        if (Firstname == false)
        {
            Console.WriteLine("Enter the Last name with capitalze and atleast had a 3 character");
        }
    }
}
