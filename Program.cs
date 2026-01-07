// See https://aka.ms/new-console-template for more information
//1
Console.WriteLine("Enter Name:");
string Username = Console.ReadLine();
Console.WriteLine("Greetings " + Username);

//2
string appName = "My Mini Program";
Console.WriteLine("Welcome to: " + appName);

Console.WriteLine("Enter Age:");
string UserAge = Console.ReadLine();
int UserAgeInt = Int32.Parse(UserAge);
if (UserAgeInt > 0)
{
    Console.WriteLine("Valid Integer");
}
Console.WriteLine("Press Any Key to Exit!");
Console.ReadKey();



