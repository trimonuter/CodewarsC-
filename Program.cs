// See https://aka.ms/new-console-template for more information

// url: https://www.codewars.com/kata/56efc695740d30f963000557/train/csharp
// program: 2_alternatingCase.cs

static string ToAlternatingCase(string s){
  string newString = "";
  for (int i = 0; i < s.Length; i++){
    if (Char.IsUpper(s[i])){
      newString += Char.ToLower(s[i]);
    }
    else{
      newString += Char.ToUpper(s[i]);
    }
  }
  return newString;
}

Console.Write("Input text: ");
string stringInput = Console.ReadLine();
Console.WriteLine(ToAlternatingCase(stringInput));