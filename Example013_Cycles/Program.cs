// Multiplication table
// Console.Clear();
// for (int i=2; i<10; i++)
// {
//   for (int j=2; j<=10; j++)
//   {
//     Console.WriteLine($"{i} x {j} = {i*j}");
//   }
//   Console.WriteLine();
// }

// Дан текст. В нем нужно все пробелы заменить черточками, маленькие буквы "к"
// заменить большими "К", а большие "С" заменить маленькими "с".
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123
// s[3] = r
string Replace (string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int length = text.Length;
  for (int i = 0; i<length; i++)
  {
    if (text[i]== oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }
  return result;
}
Console.WriteLine(text);
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);