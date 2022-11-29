Console.WriteLine("Enter user's name: ");
string username = Console.ReadLine();

if(username.ToLower() == "natalia")
{
    Console.WriteLine("Hello, my beautiful lady!");
}
else
{
    Console.Write("Hello, you, ");
    Console.Write(username);
}