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
// void CatalogInfo(string path, string indent = "")
// {
//   DirectoryInfo catalog = new DirectoryInfo(path);
//   DirectoryInfo[] catalogs = catalog.GetDirectories();
//   for (int i=0; i<catalogs.Length; i++)
//   {
//     Console.WriteLine($"{indent}{catalogs[i].Name}");
//     CatalogInfo(catalogs[i].FullName, indent + " ");
//   }
//   FileInfo[] files = catalog.GetFiles();
//   for (int i=0; i<files.Length; i++)
//   {
//     Console.WriteLine($"{indent}{files[i].Name}");
//   }
// }
// string path = @"C:\Users\vladi\OneDrive\Documents\Private\Projects\Examples\Example001_HelloConsole";
// CatalogInfo(path);

// void Towers(string from = "1", string to = "3", string some = "2", int count = 4)
// {
//   if (count > 1) Towers(from, some, to, count -1);
//   Console.WriteLine($"{from} >> {to}");
//   if (count > 1) Towers(some, to, from, count -1);
// }
// Towers();

// string emp = String.Empty;
// string [] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

// void InOrderTraversal(int pos=1)
// {
//   if (pos<tree.Length)
//   {
//     int left = 2 * pos;
//     int right = 2* pos + 1;
//     if (left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//     Console.WriteLine(tree[pos]);
//     if (right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//   }
// }
// InOrderTraversal();

// decimal fRec=0;
// decimal fIte=0;

// decimal FibonacciRecursion(int n)
// {
//   fRec++;
//   return n == 0 || n == 1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2); 
// }

// decimal FibonacciIteration(int n)
// {
//   fIte++;
//   decimal result = 1;
//   decimal f0=1;
//   decimal f1=1;
//   for (int i=2; i<n; i++)
//   {
//     result = f0+f1;
//     f0=f1;
//     f1=result;
//     fIte++;
//   }
//   return result;
// }
// Console.ReadLine();
// DateTime dt = DateTime.Now;
// for (int n=10; n<40; n++)
// {
//   Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
//   fIte=0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n=10; n<40; n++)
// {
//   Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
//   fRec = 0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.ReadLine();

// int i=0;
// void Rec()
// {
//   Console.WriteLine(i++);
//   Rec();
// }
// Rec();

// int[,] pic = new int[1000,1000];
// for (int i=0; i<1000; i++)
// {
//   pic[0,i]=1;
//   pic[i,0]=1;
//   pic[i,999]=1;
//   pic[999,i]=1;
// }
// // PrintImage(pic);
// FillImage(1,1);
// Console.WriteLine();
// // PrintImage(pic);

// void PrintImage(int[,] image)
// {
//   for (int i=0; i<image.GetLength(0); i++)
//   {
//     for (int j=0; j<image.GetLength(1); j++)
//     {
//       if (image[i,j]==0) Console.Write($" ");
//       else Console.Write($"*");
//     }
//     Console.WriteLine();
//   }
// }
// void FillImage(int row, int col)
// {
//   if (pic[row,col]==0)
//   {
//     pic[row, col]=1;
//     FillImage(row-1, col);
//     FillImage(row, col-1);
//     FillImage(row+1, col);
//     FillImage(row, col+1);
//   }
// }