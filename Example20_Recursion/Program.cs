// string NumbersFor (int a, int b)
// {
//   string result = String.Empty;
//   for (int i=a; i<=b; i++)
//   {
//     result+=$"{i} ";
//   }
//   return result;
// }
// string NumbersRec (int a, int b)
// {
//   if (a<=b) return $"{a} " + NumbersRec (a+1,b);
//   else return String.Empty;
// }
// string NumbersRecUpd (int a, int b)
// {
//   if (a<b) return $"{a} " + NumbersRecUpd (a+1,b);
//   else return String.Empty; //???
// }
// Console.WriteLine(NumbersFor(1,10));
// Console.WriteLine(NumbersRec(1,10));
// Console.WriteLine(NumbersRecUpd(1,11));

// int SumFor (int n)
// {
//   int result = 0;
//   for (int i=1; i<=n; i++) result+=i;
//   return result;
// }
// Console.WriteLine(SumFor(10));
// int SumRec (int n)
// {
//   if (n==1) return 1;
//   else return n + SumRec (n-1);
// }
// Console.WriteLine(SumRec(10));

// int FactorialFor(int n)
// {
//   int result = 1;
//   for (int i=1; i<=n; i++) result *= i;
//   return result; 
// }
// Console.WriteLine(FactorialFor(5));
// int FactorialRec(int n)
// {
//   if (n==1||n==0) return 1;
//   else return n*(FactorialRec(n-1));
// }
// Console.WriteLine(FactorialRec(5));

// int PowerFor(int a, int n)
// {
//   int result = 1;
//   for (int i=1; i<=n; i++) result *= a;
//   return result;
// }
// int PowerRec(int a, int n)
// {
//   // return n == 0 ? 1 : PowerRec(a,n-1)*a
//   if (n==0) return 1;
//   else return a*PowerRec(a, n-1);
// }
// int PowerRecMath(int a, int n)
// {
//   if (n==0) return 1;
//   else if (n%2==0) return PowerRecMath(a*a, n/2);
//   else return PowerRecMath(a,n-1)*a;
// }
// Console.WriteLine(PowerFor(2,10));
// Console.WriteLine(PowerRec(2,10));
// Console.WriteLine(PowerRecMath(2,10));

