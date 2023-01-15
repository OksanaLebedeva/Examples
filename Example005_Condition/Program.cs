Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "vladimir")
{
  Console.WriteLine("Wow, it is Vladimir!");
}
else
{
  Console.Write("Hello, ");
  Console.WriteLine(username);
}