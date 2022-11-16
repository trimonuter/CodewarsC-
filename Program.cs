// See https://aka.ms/new-console-template for more information

// url: https://www.codewars.com/kata/56b1f01c247c01db92000076/train/csharp
// program: 1_doublingCharacters.cs

static string DoubleChar(string str)
{
  string newString = "";
  for (int i = 0; i < str.Length; i++){
    for (int j = 0; j < 2; j++){
      newString += str[i];
    }
  }
  return newString;
}

Console.Write("Input text: ");
string strInput = Console.ReadLine();
Console.WriteLine(DoubleChar(strInput));