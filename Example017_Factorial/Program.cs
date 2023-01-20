double Factorial (int n)
{
  if(n==1) return 1;
  else return n*Factorial(n-1);
}
// Console.WriteLine(Factorial(5));
for (int i=1; i<40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}
