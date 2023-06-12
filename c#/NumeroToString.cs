using System;

class Program {
  public static void Main (string[] args)
  {
    string s="numero: ";
    string x;
    Console.WriteLine("inserisci numero: ");
    x = Console.ReadLine();
    Console.WriteLine("stringa: " + string.Concat(s, x));
    Console.ReadKey();
  }
}
