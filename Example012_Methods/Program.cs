// // Type 1
// void Method1()
// {
//   Console.WriteLine("The Author is ...");
// }
// //Method1();

// // Type 2
// void Method2 (string msg)
// {
//   Console.WriteLine(msg);
// }
// //Method2("Text of the message");

// void Method2_1(string msg, int count)
// {
//   int i = 0;
//   while (i<count)
//   {
//     Console.WriteLine(msg);
//     i++;
//   }
// }
// //Method2_1(count: 4, msg: "Text");

// // Type 3
// int Method3()
// {
//   return DateTime.Now.Year;
// }
// int year = Method3();
// //Console.WriteLine(year);

// // Type 4
// string Method4(int count, string text)
// {
//   int i = 0;
//   string result = String.Empty;
//   while (i < count) 
//   {
//     result = result + text;
//     i++;
//   }
//   return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

string Method4(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}
string res = Method4(10, "Sdf ");
Console.WriteLine(res);