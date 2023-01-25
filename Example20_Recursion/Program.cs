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

// char[] s = {'a', 'b', 'c' , 'd'};
// int count = s.Length;
// int n=1;
// for (int i=0; i<s.Length; i++)
// {
//   for (int j=0; j<s.Length; j++) 
//   {
//     for (int k=0; k<s.Length; k++) 
//     {
//       for (int l=0; l<s.Length; l++) 
//       {
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//       }
//     }
//   }
// }
// int n=1;
// void FindWords (string alphabet, char[] word, int length = 0)
// {
//   if (length == word.Length)
//   {
//     Console.WriteLine($"{n++} {new String(word)}");
//     return;
//   }
//   for (int i=0; i<alphabet.Length; i++)
//   {
//     word[length]=alphabet[i];
//     FindWords(alphabet, word, length + 1);
//   }
// }
// FindWords("abcd", new char[2]);
void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo catalog = new DirectoryInfo(path);
  DirectoryInfo[] catalogs = catalog.GetDirectories();
  for (int i=0; i<catalogs.Length; i++)
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + " ");
  }
  FileInfo[] files = catalog.GetFiles();
  for (int i=0; i<files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}");
  }
}
string path = @"C:\Users\vladi\OneDrive\Documents\Private\Projects\Examples\Example001_HelloConsole";
CatalogInfo(path);